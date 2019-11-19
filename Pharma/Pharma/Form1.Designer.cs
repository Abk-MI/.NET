namespace Pharma
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRecherchePrenom = new System.Windows.Forms.TextBox();
            this.txtBoxRechercheNom = new System.Windows.Forms.TextBox();
            this.txtBoxRechercheCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimeDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCivilite = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxFacebook = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.dataGridViewAfficheClients = new System.Windows.Forms.DataGridView();
            this.groupBoxGamme = new System.Windows.Forms.GroupBox();
            this.panelGamme = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panelInteret = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxInfoSMS = new System.Windows.Forms.CheckBox();
            this.checkBoxInfoEmail = new System.Windows.Forms.CheckBox();
            this.txtBoxRemarque = new System.Windows.Forms.RichTextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfficheClients)).BeginInit();
            this.groupBoxGamme.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxRecherchePrenom);
            this.groupBox1.Controls.Add(this.txtBoxRechercheNom);
            this.groupBox1.Controls.Add(this.txtBoxRechercheCode);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Code";
            // 
            // txtBoxRecherchePrenom
            // 
            this.txtBoxRecherchePrenom.Location = new System.Drawing.Point(290, 63);
            this.txtBoxRecherchePrenom.Name = "txtBoxRecherchePrenom";
            this.txtBoxRecherchePrenom.Size = new System.Drawing.Size(113, 22);
            this.txtBoxRecherchePrenom.TabIndex = 9;
            // 
            // txtBoxRechercheNom
            // 
            this.txtBoxRechercheNom.Location = new System.Drawing.Point(146, 63);
            this.txtBoxRechercheNom.Name = "txtBoxRechercheNom";
            this.txtBoxRechercheNom.Size = new System.Drawing.Size(116, 22);
            this.txtBoxRechercheNom.TabIndex = 4;
            this.txtBoxRechercheNom.TextChanged += new System.EventHandler(this.txtBoxRechercheNom_TextChanged);
            // 
            // txtBoxRechercheCode
            // 
            this.txtBoxRechercheCode.Location = new System.Drawing.Point(22, 63);
            this.txtBoxRechercheCode.Name = "txtBoxRechercheCode";
            this.txtBoxRechercheCode.Size = new System.Drawing.Size(100, 22);
            this.txtBoxRechercheCode.TabIndex = 2;
            this.txtBoxRechercheCode.TextChanged += new System.EventHandler(this.txtBoxRechercheCode_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimeDateNaissance);
            this.groupBox2.Controls.Add(this.comboBoxCivilite);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBoxFacebook);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBoxEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBoxAdress);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBoxTel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxNom);
            this.groupBox2.Controls.Add(this.txtBoxPrenom);
            this.groupBox2.Location = new System.Drawing.Point(445, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renseignements Obligatoire";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dateTimeDateNaissance
            // 
            this.dateTimeDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDateNaissance.Location = new System.Drawing.Point(437, 63);
            this.dateTimeDateNaissance.Name = "dateTimeDateNaissance";
            this.dateTimeDateNaissance.Size = new System.Drawing.Size(242, 22);
            this.dateTimeDateNaissance.TabIndex = 20;
            this.dateTimeDateNaissance.Value = new System.DateTime(2019, 5, 17, 0, 0, 0, 0);
            // 
            // comboBoxCivilite
            // 
            this.comboBoxCivilite.FormattingEnabled = true;
            this.comboBoxCivilite.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.comboBoxCivilite.Location = new System.Drawing.Point(283, 61);
            this.comboBoxCivilite.Name = "comboBoxCivilite";
            this.comboBoxCivilite.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCivilite.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Date de Naissance:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Civilité*:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Facebook*:";
            // 
            // txtBoxFacebook
            // 
            this.txtBoxFacebook.Location = new System.Drawing.Point(227, 204);
            this.txtBoxFacebook.Name = "txtBoxFacebook";
            this.txtBoxFacebook.Size = new System.Drawing.Size(309, 22);
            this.txtBoxFacebook.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adress Email*:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(17, 204);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(171, 22);
            this.txtBoxEmail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adress*:";
            // 
            // txtBoxAdress
            // 
            this.txtBoxAdress.Location = new System.Drawing.Point(227, 134);
            this.txtBoxAdress.Name = "txtBoxAdress";
            this.txtBoxAdress.Size = new System.Drawing.Size(221, 22);
            this.txtBoxAdress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Télephone*:";
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(17, 134);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(171, 22);
            this.txtBoxTel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nom*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prénom*:";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(20, 63);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 22);
            this.txtBoxNom.TabIndex = 4;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(142, 63);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPrenom.TabIndex = 3;
            // 
            // dataGridViewAfficheClients
            // 
            this.dataGridViewAfficheClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAfficheClients.Location = new System.Drawing.Point(19, 132);
            this.dataGridViewAfficheClients.Name = "dataGridViewAfficheClients";
            this.dataGridViewAfficheClients.RowTemplate.Height = 24;
            this.dataGridViewAfficheClients.Size = new System.Drawing.Size(409, 358);
            this.dataGridViewAfficheClients.TabIndex = 2;
            this.dataGridViewAfficheClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAfficheClients_CellClick);
            this.dataGridViewAfficheClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAfficheClients_CellContentClick);
            // 
            // groupBoxGamme
            // 
            this.groupBoxGamme.Controls.Add(this.panelGamme);
            this.groupBoxGamme.Location = new System.Drawing.Point(445, 274);
            this.groupBoxGamme.Name = "groupBoxGamme";
            this.groupBoxGamme.Size = new System.Drawing.Size(239, 265);
            this.groupBoxGamme.TabIndex = 9;
            this.groupBoxGamme.TabStop = false;
            this.groupBoxGamme.Text = "Quelles Gamme vous intéressent";
            // 
            // panelGamme
            // 
            this.panelGamme.AutoScroll = true;
            this.panelGamme.Location = new System.Drawing.Point(6, 29);
            this.panelGamme.Name = "panelGamme";
            this.panelGamme.Size = new System.Drawing.Size(227, 230);
            this.panelGamme.TabIndex = 0;
            this.panelGamme.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGamme_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panelInteret);
            this.groupBox4.Location = new System.Drawing.Point(725, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 265);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Etes-vous plutot intéressé(e) pour";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // panelInteret
            // 
            this.panelInteret.AutoScroll = true;
            this.panelInteret.Location = new System.Drawing.Point(6, 29);
            this.panelInteret.Name = "panelInteret";
            this.panelInteret.Size = new System.Drawing.Size(227, 230);
            this.panelInteret.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxInfoSMS);
            this.groupBox5.Controls.Add(this.checkBoxInfoEmail);
            this.groupBox5.Controls.Add(this.txtBoxRemarque);
            this.groupBox5.Location = new System.Drawing.Point(1007, 274);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(439, 275);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Remarques Suggestions";
            // 
            // checkBoxInfoSMS
            // 
            this.checkBoxInfoSMS.AutoSize = true;
            this.checkBoxInfoSMS.Location = new System.Drawing.Point(20, 244);
            this.checkBoxInfoSMS.Name = "checkBoxInfoSMS";
            this.checkBoxInfoSMS.Size = new System.Drawing.Size(414, 21);
            this.checkBoxInfoSMS.TabIndex = 9;
            this.checkBoxInfoSMS.Text = "J\'accepte de recevoir des informations et des offres par SMS";
            this.checkBoxInfoSMS.UseVisualStyleBackColor = true;
            // 
            // checkBoxInfoEmail
            // 
            this.checkBoxInfoEmail.AutoSize = true;
            this.checkBoxInfoEmail.Location = new System.Drawing.Point(20, 222);
            this.checkBoxInfoEmail.Name = "checkBoxInfoEmail";
            this.checkBoxInfoEmail.Size = new System.Drawing.Size(418, 21);
            this.checkBoxInfoEmail.TabIndex = 8;
            this.checkBoxInfoEmail.Text = "J\'accepte de recevoir des informations et des offres par email";
            this.checkBoxInfoEmail.UseVisualStyleBackColor = true;
            // 
            // txtBoxRemarque
            // 
            this.txtBoxRemarque.Location = new System.Drawing.Point(20, 41);
            this.txtBoxRemarque.Name = "txtBoxRemarque";
            this.txtBoxRemarque.Size = new System.Drawing.Size(408, 175);
            this.txtBoxRemarque.TabIndex = 0;
            this.txtBoxRemarque.Text = "";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(102, 516);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 33);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(196, 516);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 33);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(293, 516);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(92, 33);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(1343, 573);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(92, 32);
            this.btnQuitter.TabIndex = 15;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(1343, 611);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(92, 32);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 654);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxGamme);
            this.Controls.Add(this.dataGridViewAfficheClients);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfficheClients)).EndInit();
            this.groupBoxGamme.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRechercheNom;
        private System.Windows.Forms.TextBox txtBoxRechercheCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.DateTimePicker dateTimeDateNaissance;
        private System.Windows.Forms.ComboBox comboBoxCivilite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxFacebook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxAdress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.DataGridView dataGridViewAfficheClients;
        private System.Windows.Forms.GroupBox groupBoxGamme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox txtBoxRemarque;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.CheckBox checkBoxInfoSMS;
        private System.Windows.Forms.CheckBox checkBoxInfoEmail;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panelGamme;
        private System.Windows.Forms.Panel panelInteret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRecherchePrenom;
        private System.Windows.Forms.Button btnAnnuler;
    }
}

