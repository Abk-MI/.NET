using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.DAOImp;
using ClassLibrary.Connexion;
using MySql.Data.MySqlClient;
using ClassLibrary.Entities;

namespace Pharma
{
    enum MODE { Consultation, Modification , Ajout };
    public partial class Form1 : Form
    {
        
        FactoryConnection _fc = new FactoryConnection("Server=localhost;Database=pharma;user Id=root;" + "Password=");

        DAOImpClients _imp = new DAOImpClients("Server=localhost;Database=pharma;user Id=root;" + "Password=");

        List<CheckBox> _listeGamme = new List<CheckBox>();
        List<CheckBox> _listeInteret = new List<CheckBox>();
        List<TextBox> _listeAutre = new List<TextBox>();

        int getCode;
        MODE _mode = MODE.Consultation;

        public Form1()
        {
            InitializeComponent();

            // Affichage Clients dans la DataGrid
            dataGridViewAfficheClients.DataSource = _imp.recupererTousClients();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ActiverModeAjout();
        }

        void ajouter()
        {
            byte infoEmail = 0;
            byte infoSMS = 0;

            if (checkBoxInfoEmail.Checked)
            {
                infoEmail = 1;
            }
            if (checkBoxInfoSMS.Checked)
            {
                infoSMS = 1;
            }

            try
            {
                if (txtBoxNom.Text == "" || txtBoxPrenom.Text == "" || comboBoxCivilite.SelectedItem == null || txtBoxTel.Text == "" || txtBoxAdress.Text == "" || txtBoxEmail.Text == "" || txtBoxFacebook.Text == "")
                {
                    MessageBox.Show("Vérifier les champs");
                }
                else
                {
                    Clients _c = new Clients(txtBoxNom.Text, txtBoxPrenom.Text, comboBoxCivilite.SelectedItem.ToString(), dateTimeDateNaissance.Value, txtBoxTel.Text, txtBoxAdress.Text, txtBoxEmail.Text, txtBoxFacebook.Text, infoSMS, infoEmail);

                    bool test = _imp.ajouterClients(_c);


                    MySqlDataReader _reader = _fc.LireDeBD("SELECT max(codeClient) FROM client;");

                    int get_Code = 0;

                    while (_reader.Read())
                    {
                        get_Code = _reader.GetInt16(0);
                    }
                    _reader.Close();

                    bool _testOccurenceGamme = false;
                    for (int i = 0; i < _listeGamme.Count - 1; i++)
                    {
                        if (_listeGamme[i].Text == _listeAutre[0].Text)
                        {
                            _testOccurenceGamme = true;
                        }
                    }

                    for (int i = 0; i < _listeGamme.Count; i++)
                    {
                        if (_listeGamme[i].Checked)
                        {
                            if (_listeGamme[i].Text == "Autre")
                            {
                                if (_listeAutre[0].TextLength != 0 && !_testOccurenceGamme)
                                {
                                    _fc.EcrireDansBD("INSERT INTO `autre_gamme` (`ID_autregamme`, `libelle_autregamme`, `CodeClient`) VALUES(NULL, '" + _listeAutre[0].Text + "', '" + get_Code + "');");
                                }
                            }
                            else
                            {
                                _fc.EcrireDansBD("INSERT INTO `avoir_gammes` (`CodeClient`, `libelle_gamme`) VALUES ('" + get_Code + "', '" + _listeGamme[i].Text + "');");
                            }
                        }
                    }

                    // pour interet
                    bool _testOccurenceInteret = false;
                    for (int i = 0; i < _listeInteret.Count - 1; i++)
                    {
                        if (_listeInteret[i].Text == _listeAutre[1].Text)
                        {
                            _testOccurenceInteret = true;
                        }
                    }

                    for (int i = 0; i < _listeInteret.Count; i++)
                    {
                        if (_listeInteret[i].Checked)
                        {
                            if (_listeInteret[i].Text == "Autre")
                            {
                                if (_listeAutre[1].TextLength != 0 && !_testOccurenceInteret)
                                {
                                    _fc.EcrireDansBD("INSERT INTO `autre_interet` (`ID_autreinteret`, `libelle_autreinteret`, `CodeClient`) VALUES(NULL, '" + _listeAutre[1].Text.ToString() + "', '" + get_Code + "');");
                                }
                            }
                            else
                            {
                                _fc.EcrireDansBD("INSERT INTO `avoir_interets` (`CodeClient`, `libelle_interet`) VALUES ('" + get_Code + "', '" + _listeInteret[i].Text + "');");
                            }
                        }
                    }

                    if (test)
                    {
                        MessageBox.Show("Ajouter avec succées");
                        txtBoxNom.Text = ""; txtBoxPrenom.Text = ""; comboBoxCivilite.SelectedItem = null; txtBoxTel.Text = "";
                        txtBoxAdress.Text = ""; txtBoxEmail.Text = ""; txtBoxFacebook.Text = "";
                        // Affichage Clients dans la DataGrid
                        dataGridViewAfficheClients.DataSource = _imp.recupererTousClients();
                    }
                }
                ActiverModeconsultation();
            }
            catch (MySqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        void Modifier()
        {
            
            byte infoEmail = 0;
            byte infoSMS = 0;

            if (checkBoxInfoEmail.Checked)
            {
                infoEmail = 1;
            }
            if (checkBoxInfoSMS.Checked)
            {
                infoSMS = 1;
            }
            
            Clients _c = new Clients(txtBoxNom.Text, txtBoxPrenom.Text, comboBoxCivilite.SelectedItem.ToString(), dateTimeDateNaissance.Value, txtBoxTel.Text, txtBoxAdress.Text, txtBoxEmail.Text, txtBoxFacebook.Text, infoSMS, infoEmail);
        
            bool test = _imp.modifierClient(_c, getCode);
            
            if (test)
            {
                MessageBox.Show("Modification avec succées");
                txtBoxNom.Text = ""; txtBoxPrenom.Text = ""; comboBoxCivilite.SelectedItem = null; txtBoxTel.Text = "";
                txtBoxAdress.Text = ""; txtBoxEmail.Text = ""; txtBoxFacebook.Text = "";
                dataGridViewAfficheClients.DataSource = _imp.recupererTousClients();
            }
            else
            {
                MessageBox.Show("noooooooo");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // GroupBox Gamme
            MySqlDataReader _reader = _fc.LireDeBD("SELECT * FROM `gammes`");
            
            int a = 1;
            while (_reader.Read())
            {
                CheckBox chk = new CheckBox();
                chk.Text = _reader.GetString(0);
                chk.Name = "checkbox" + _reader.GetString(0);
                chk.Top = a * 20;
                panelGamme.Controls.Add(chk);
                a += 1;
                _listeGamme.Add(chk);
            }
            _reader.Close();

            CheckBox chkAut = new CheckBox();
            chkAut.Text = "Autre";
            chkAut.Top = a * 20;
            panelGamme.Controls.Add(chkAut);
            _listeGamme.Add(chkAut);
            TextBox textBoxAutre = new TextBox();
            textBoxAutre.Left = 30;
            textBoxAutre.Top = (a + 1) * 21;
            
            panelGamme.Controls.Add(textBoxAutre);
           // panelGamme.
            _listeAutre.Add(textBoxAutre);

            // GroupBox Interet
            MySqlDataReader _reader2 = _fc.LireDeBD("SELECT * FROM `interet`");
            int b = 1;
            while (_reader2.Read())
            {
                CheckBox chk2 = new CheckBox();
                chk2.Text = _reader2.GetString(0);
                chk2.Name = "checkbox" + _reader2.GetString(0);
                chk2.Top = b * 21;
                panelInteret.Controls.Add(chk2);
                b += 1;
                _listeInteret.Add(chk2);
            }
            _reader2.Close();

            CheckBox chkAut2 = new CheckBox();
            chkAut2.Text = "Autre";
            chkAut2.Top = b * 21;
            TextBox textBoxAutre2 = new TextBox();
            textBoxAutre2.Left = 30;
            textBoxAutre2.Top = (b + 1) * 22;
            panelInteret.Controls.Add(chkAut2);
            panelInteret.Controls.Add(textBoxAutre2);
            _listeInteret.Add(chkAut2);

            _listeAutre.Add(textBoxAutre2);

            ActiverModeconsultation();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewAfficheClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _fc.FermerConexion();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewAfficheClients.CurrentCell.Value != null)
            {
                if (MessageBox.Show(this, "Continuez la suppression ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int _code = (int)dataGridViewAfficheClients.CurrentRow.Cells[0].Value;
                    string _nom = dataGridViewAfficheClients.CurrentRow.Cells[1].Value.ToString();
                    string _prenom = dataGridViewAfficheClients.CurrentRow.Cells[2].Value.ToString();
                    string _adresse = dataGridViewAfficheClients.CurrentRow.Cells[3].Value.ToString();
                    string _civilite = dataGridViewAfficheClients.CurrentRow.Cells[4].Value.ToString();
                    DateTime _dateNaissance = Convert.ToDateTime(dataGridViewAfficheClients.CurrentRow.Cells[5].Value.ToString());
                    string _tel = dataGridViewAfficheClients.CurrentRow.Cells[6].Value.ToString();
                    string _email = dataGridViewAfficheClients.CurrentRow.Cells[7].Value.ToString();
                    string _facebook = dataGridViewAfficheClients.CurrentRow.Cells[8].Value.ToString();
                    byte _infoParSMS = (byte)dataGridViewAfficheClients.CurrentRow.Cells[9].Value;
                    byte _infoParEMAIL = (byte)dataGridViewAfficheClients.CurrentRow.Cells[10].Value;

                    Clients _c = new Clients(_code, _nom, _prenom, _civilite, _dateNaissance, _tel, _adresse, _email, _facebook, _infoParSMS, _infoParEMAIL);

                    bool test = _imp.supprimerClients(_c);

                    if (test)
                    {
                        MessageBox.Show("Suppression avec succées");
                        dataGridViewAfficheClients.DataSource = _imp.recupererTousClients();
                    }
                    else
                    {
                        MessageBox.Show("Erreur de suppression");
                    }
                }

                
            }
            else
            {
                MessageBox.Show(this, "Merci de selectionné un Clients", "ATTENTION !!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            ActiverMODEMODIFICATION();
        }

        

        private void dataGridViewAfficheClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte _infoParSMS = (byte)dataGridViewAfficheClients.CurrentRow.Cells[9].Value;
            byte _infoParEMAIL = (byte)dataGridViewAfficheClients.CurrentRow.Cells[10].Value;
            // textBoxCode.Text= dataGridViewAfficheClients.CurrentRow.Cells[0].Value.ToString();

            getCode = (int)dataGridViewAfficheClients.CurrentRow.Cells[0].Value ;
            txtBoxNom.Text = dataGridViewAfficheClients.CurrentRow.Cells[1].Value.ToString();
            txtBoxPrenom.Text = dataGridViewAfficheClients.CurrentRow.Cells[2].Value.ToString();
            comboBoxCivilite.SelectedItem = dataGridViewAfficheClients.CurrentRow.Cells[4].Value.ToString();
            txtBoxTel.Text = dataGridViewAfficheClients.CurrentRow.Cells[6].Value.ToString();
            txtBoxAdress.Text = dataGridViewAfficheClients.CurrentRow.Cells[3].Value.ToString();
            txtBoxEmail.Text = dataGridViewAfficheClients.CurrentRow.Cells[7].Value.ToString();
            txtBoxFacebook.Text = dataGridViewAfficheClients.CurrentRow.Cells[8].Value.ToString();
            dateTimeDateNaissance.Value = Convert.ToDateTime(dataGridViewAfficheClients.CurrentRow.Cells[5].Value.ToString());
        }

        public void Chercher(String _categorie,String _chaine)
        {
            List<Clients> _listeClientsfiltrer = new List<Clients>();
            List<Clients> _listeClients = _imp.recupererTousClients();
                
          

            for (int i = 0; i < _listeClients.LongCount(); i++)
            {
                switch (_categorie)
                {
                    case "CodeClient":
                        if ((_listeClients[i].Code.ToString()).Contains(_chaine) == true)
                        {
                            
                            _listeClientsfiltrer.Add(_listeClients[i]);
                            
                        }; break;
                    case "Nom":
                        if ((_listeClients[i].Nom.ToString()).Contains(_chaine) == true)
                        {
                            _listeClientsfiltrer.Add(_listeClients[i]);

                        }; break;
                    case "Prenom":
                        if ((_listeClients[i].Prenom.ToString()).Contains(_chaine) == true)
                        {
                            _listeClientsfiltrer.Add(_listeClients[i]);
                        }; break;
                    
                    default: break;
                }
            }
            dataGridViewAfficheClients.DataSource = _listeClientsfiltrer;
            
        }

        private void txtBoxRechercheNom_TextChanged(object sender, EventArgs e)
        {
            Chercher("Nom",txtBoxRechercheNom.Text);
        }

        private void txtBoxRecherchePrenom_TextChanged(object sender, EventArgs e)
        {
            Chercher("Prenom", txtBoxRecherchePrenom.Text);
        }

        private void txtBoxRechercheCode_TextChanged(object sender, EventArgs e)
        {
            Chercher("CodeClient", txtBoxRechercheCode.Text);
        }

        private void panelGamme_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ActiverModeconsultation();
        }


        void ActiverModeconsultation()
        {
            _mode = MODE.Consultation;

            txtBoxNom.Enabled = false;
            txtBoxPrenom.Enabled = false;
            comboBoxCivilite.Enabled = false;
            dateTimeDateNaissance.Enabled = false;
            txtBoxTel.Enabled = false;
            txtBoxAdress.Enabled = false;
            txtBoxEmail.Enabled = false;
            txtBoxFacebook.Enabled = false;
            txtBoxRemarque.Enabled = false;
            checkBoxInfoEmail.Enabled = false;
            checkBoxInfoSMS.Enabled = false;

            btnModifier.Visible = true;
            btnAjouter.Visible = true;
            btnSupprimer.Visible = true;

            btnQuitter.Text = "Quitter";
            btnAnnuler.Visible = false;

            for(int i = 0; i < _listeGamme.Count;i++)
            {
                // completer checked
                _listeGamme[i].Enabled = false;
            }
            for (int i = 0; i < _listeInteret.Count; i++)
            {
                _listeInteret[i].Enabled = false;
            }
            for (int i = 0; i < _listeAutre.Count; i++)
            {
                _listeAutre[i].Enabled = false;
            }
        }
        void ActiverMODEMODIFICATION()
        {
            _mode = MODE.Modification;

            txtBoxNom.Enabled = true;
            txtBoxPrenom.Enabled = true;
            comboBoxCivilite.Enabled = true;
            dateTimeDateNaissance.Enabled = true;
            txtBoxTel.Enabled = true;
            txtBoxAdress.Enabled = true;
            txtBoxEmail.Enabled = true;
            txtBoxFacebook.Enabled = true;
            txtBoxRemarque.Enabled = true;
            checkBoxInfoEmail.Enabled = true;
            checkBoxInfoSMS.Enabled = true;

            btnModifier.Visible = false;
            btnAjouter.Visible = false;
            btnSupprimer.Visible = false;

            btnQuitter.Text = "Modifier";
            btnAnnuler.Visible = true;

            for (int i = 0; i < _listeGamme.Count; i++)
            {
                _listeGamme[i].Enabled = true;
            }
            for (int i = 0; i < _listeInteret.Count; i++)
            {
                _listeInteret[i].Enabled = true;
            }
            for (int i = 0; i < _listeAutre.Count; i++)
            {
                _listeAutre[i].Enabled = true;
            }
        }
        void ActiverModeAjout()
        {
            _mode = MODE.Ajout;

            txtBoxNom.Enabled = true;
            txtBoxPrenom.Enabled = true;
            comboBoxCivilite.Enabled = true;
            dateTimeDateNaissance.Enabled = true;
            txtBoxTel.Enabled = true;
            txtBoxAdress.Enabled = true;
            txtBoxEmail.Enabled = true;
            txtBoxFacebook.Enabled = true;
            txtBoxRemarque.Enabled = true;
            checkBoxInfoEmail.Enabled = true;
            checkBoxInfoSMS.Enabled = true;
            // ****************************
            txtBoxNom.Text = "";
            txtBoxPrenom.Text = "";
            comboBoxCivilite.SelectedIndex = -1;
            txtBoxTel.Text = "";
            txtBoxAdress.Text = "";
            txtBoxEmail.Text = "";
            txtBoxFacebook.Text = "";
            txtBoxRemarque.Text = "";
            checkBoxInfoEmail.Checked = false;
            checkBoxInfoSMS.Checked = false;

            // ****************************

            btnModifier.Visible = false;
            btnAjouter.Visible = false;
            btnSupprimer.Visible = false;

            btnQuitter.Text = "Ajouter";
            btnAnnuler.Visible = true;

            for (int i = 0; i < _listeGamme.Count; i++)
            {
                _listeGamme[i].Enabled = true;
            }
            for (int i = 0; i < _listeInteret.Count; i++)
            {
                _listeInteret[i].Enabled = true;
            }
            for (int i = 0; i < _listeAutre.Count; i++)
            {
                _listeAutre[i].Enabled = true;
            }
        }

        private void fermer()
        {
            if (MessageBox.Show(this, "Etes-vous sûr de quitter ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case MODE.Ajout: ajouter(); break;

                case MODE.Consultation: fermer(); break;
                case MODE.Modification: Modifier(); break;
            }
        }
    }
}
