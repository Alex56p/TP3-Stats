namespace TP3_Stats
{
    partial class Form_Menu
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
            this.BTN_CommencerPartie = new System.Windows.Forms.Button();
            this.TB_Joueur1 = new System.Windows.Forms.GroupBox();
            this.CB_Joueur1 = new System.Windows.Forms.ComboBox();
            this.RB_Courageux1 = new System.Windows.Forms.RadioButton();
            this.RB_Prudent1 = new System.Windows.Forms.RadioButton();
            this.RB_Moyen1 = new System.Windows.Forms.RadioButton();
            this.GB_Ordinateur1 = new System.Windows.Forms.GroupBox();
            this.GB_Ordinateur2 = new System.Windows.Forms.GroupBox();
            this.RB_Courageux2 = new System.Windows.Forms.RadioButton();
            this.RB_Moyen2 = new System.Windows.Forms.RadioButton();
            this.RB_Prudent2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CB_Joueur2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Compte1 = new System.Windows.Forms.CheckBox();
            this.CB_Compte2 = new System.Windows.Forms.CheckBox();
            this.TB_Joueur1.SuspendLayout();
            this.GB_Ordinateur1.SuspendLayout();
            this.GB_Ordinateur2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_CommencerPartie
            // 
            this.BTN_CommencerPartie.Location = new System.Drawing.Point(451, 296);
            this.BTN_CommencerPartie.Name = "BTN_CommencerPartie";
            this.BTN_CommencerPartie.Size = new System.Drawing.Size(133, 23);
            this.BTN_CommencerPartie.TabIndex = 0;
            this.BTN_CommencerPartie.Text = "Commencer la partie...";
            this.BTN_CommencerPartie.UseVisualStyleBackColor = true;
            this.BTN_CommencerPartie.Click += new System.EventHandler(this.BTN_CommencerPartie_Click);
            // 
            // TB_Joueur1
            // 
            this.TB_Joueur1.Controls.Add(this.CB_Joueur1);
            this.TB_Joueur1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Joueur1.Location = new System.Drawing.Point(53, 70);
            this.TB_Joueur1.Name = "TB_Joueur1";
            this.TB_Joueur1.Size = new System.Drawing.Size(151, 64);
            this.TB_Joueur1.TabIndex = 1;
            this.TB_Joueur1.TabStop = false;
            this.TB_Joueur1.Text = "Joueur 1";
            // 
            // CB_Joueur1
            // 
            this.CB_Joueur1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Joueur1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CB_Joueur1.FormattingEnabled = true;
            this.CB_Joueur1.Items.AddRange(new object[] {
            "Ordinateur",
            "Humain"});
            this.CB_Joueur1.Location = new System.Drawing.Point(7, 26);
            this.CB_Joueur1.Name = "CB_Joueur1";
            this.CB_Joueur1.Size = new System.Drawing.Size(121, 27);
            this.CB_Joueur1.TabIndex = 0;
            this.CB_Joueur1.SelectedIndexChanged += new System.EventHandler(this.CB_Joueur1_SelectedIndexChanged);
            // 
            // RB_Courageux1
            // 
            this.RB_Courageux1.AutoSize = true;
            this.RB_Courageux1.Location = new System.Drawing.Point(17, 25);
            this.RB_Courageux1.Name = "RB_Courageux1";
            this.RB_Courageux1.Size = new System.Drawing.Size(116, 23);
            this.RB_Courageux1.TabIndex = 1;
            this.RB_Courageux1.TabStop = true;
            this.RB_Courageux1.Text = "Courageux";
            this.RB_Courageux1.UseVisualStyleBackColor = true;
            // 
            // RB_Prudent1
            // 
            this.RB_Prudent1.AutoSize = true;
            this.RB_Prudent1.Location = new System.Drawing.Point(16, 80);
            this.RB_Prudent1.Name = "RB_Prudent1";
            this.RB_Prudent1.Size = new System.Drawing.Size(94, 23);
            this.RB_Prudent1.TabIndex = 2;
            this.RB_Prudent1.TabStop = true;
            this.RB_Prudent1.Text = "Prudent";
            this.RB_Prudent1.UseVisualStyleBackColor = true;
            // 
            // RB_Moyen1
            // 
            this.RB_Moyen1.AutoSize = true;
            this.RB_Moyen1.Location = new System.Drawing.Point(17, 51);
            this.RB_Moyen1.Name = "RB_Moyen1";
            this.RB_Moyen1.Size = new System.Drawing.Size(80, 23);
            this.RB_Moyen1.TabIndex = 3;
            this.RB_Moyen1.TabStop = true;
            this.RB_Moyen1.Text = "Moyen";
            this.RB_Moyen1.UseVisualStyleBackColor = true;
            // 
            // GB_Ordinateur1
            // 
            this.GB_Ordinateur1.Controls.Add(this.RB_Courageux1);
            this.GB_Ordinateur1.Controls.Add(this.RB_Moyen1);
            this.GB_Ordinateur1.Controls.Add(this.RB_Prudent1);
            this.GB_Ordinateur1.Enabled = false;
            this.GB_Ordinateur1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Ordinateur1.Location = new System.Drawing.Point(22, 140);
            this.GB_Ordinateur1.Name = "GB_Ordinateur1";
            this.GB_Ordinateur1.Size = new System.Drawing.Size(220, 109);
            this.GB_Ordinateur1.TabIndex = 4;
            this.GB_Ordinateur1.TabStop = false;
            this.GB_Ordinateur1.Text = "Difficulté Ordinateur 1";
            // 
            // GB_Ordinateur2
            // 
            this.GB_Ordinateur2.Controls.Add(this.RB_Courageux2);
            this.GB_Ordinateur2.Controls.Add(this.RB_Moyen2);
            this.GB_Ordinateur2.Controls.Add(this.RB_Prudent2);
            this.GB_Ordinateur2.Enabled = false;
            this.GB_Ordinateur2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Ordinateur2.Location = new System.Drawing.Point(356, 140);
            this.GB_Ordinateur2.Name = "GB_Ordinateur2";
            this.GB_Ordinateur2.Size = new System.Drawing.Size(220, 109);
            this.GB_Ordinateur2.TabIndex = 6;
            this.GB_Ordinateur2.TabStop = false;
            this.GB_Ordinateur2.Text = "Difficulté Ordinateur 2";
            // 
            // RB_Courageux2
            // 
            this.RB_Courageux2.AutoSize = true;
            this.RB_Courageux2.Location = new System.Drawing.Point(17, 25);
            this.RB_Courageux2.Name = "RB_Courageux2";
            this.RB_Courageux2.Size = new System.Drawing.Size(116, 23);
            this.RB_Courageux2.TabIndex = 1;
            this.RB_Courageux2.TabStop = true;
            this.RB_Courageux2.Text = "Courageux";
            this.RB_Courageux2.UseVisualStyleBackColor = true;
            // 
            // RB_Moyen2
            // 
            this.RB_Moyen2.AutoSize = true;
            this.RB_Moyen2.Location = new System.Drawing.Point(17, 51);
            this.RB_Moyen2.Name = "RB_Moyen2";
            this.RB_Moyen2.Size = new System.Drawing.Size(80, 23);
            this.RB_Moyen2.TabIndex = 3;
            this.RB_Moyen2.TabStop = true;
            this.RB_Moyen2.Text = "Moyen";
            this.RB_Moyen2.UseVisualStyleBackColor = true;
            // 
            // RB_Prudent2
            // 
            this.RB_Prudent2.AutoSize = true;
            this.RB_Prudent2.Location = new System.Drawing.Point(16, 80);
            this.RB_Prudent2.Name = "RB_Prudent2";
            this.RB_Prudent2.Size = new System.Drawing.Size(94, 23);
            this.RB_Prudent2.TabIndex = 2;
            this.RB_Prudent2.TabStop = true;
            this.RB_Prudent2.Text = "Prudent";
            this.RB_Prudent2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CB_Joueur2);
            this.groupBox3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(387, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 64);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Joueur 2";
            // 
            // CB_Joueur2
            // 
            this.CB_Joueur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Joueur2.FormattingEnabled = true;
            this.CB_Joueur2.Items.AddRange(new object[] {
            "Ordinateur",
            "Humain"});
            this.CB_Joueur2.Location = new System.Drawing.Point(7, 26);
            this.CB_Joueur2.Name = "CB_Joueur2";
            this.CB_Joueur2.Size = new System.Drawing.Size(121, 27);
            this.CB_Joueur2.TabIndex = 0;
            this.CB_Joueur2.SelectedIndexChanged += new System.EventHandler(this.CB_Joueur2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "BLACK JACK";
            // 
            // CB_Compte1
            // 
            this.CB_Compte1.AutoSize = true;
            this.CB_Compte1.Enabled = false;
            this.CB_Compte1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.CB_Compte1.Location = new System.Drawing.Point(38, 255);
            this.CB_Compte1.Name = "CB_Compte1";
            this.CB_Compte1.Size = new System.Drawing.Size(170, 23);
            this.CB_Compte1.TabIndex = 8;
            this.CB_Compte1.Text = "Compte les cartes";
            this.CB_Compte1.UseVisualStyleBackColor = true;
            // 
            // CB_Compte2
            // 
            this.CB_Compte2.AutoSize = true;
            this.CB_Compte2.Enabled = false;
            this.CB_Compte2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.CB_Compte2.Location = new System.Drawing.Point(373, 255);
            this.CB_Compte2.Name = "CB_Compte2";
            this.CB_Compte2.Size = new System.Drawing.Size(170, 23);
            this.CB_Compte2.TabIndex = 9;
            this.CB_Compte2.Text = "Compte les cartes";
            this.CB_Compte2.UseVisualStyleBackColor = true;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(596, 336);
            this.Controls.Add(this.CB_Compte2);
            this.Controls.Add(this.CB_Compte1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB_Ordinateur2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GB_Ordinateur1);
            this.Controls.Add(this.TB_Joueur1);
            this.Controls.Add(this.BTN_CommencerPartie);
            this.Name = "Form_Menu";
            this.Text = "Menu Principal...";
            this.TB_Joueur1.ResumeLayout(false);
            this.GB_Ordinateur1.ResumeLayout(false);
            this.GB_Ordinateur1.PerformLayout();
            this.GB_Ordinateur2.ResumeLayout(false);
            this.GB_Ordinateur2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CommencerPartie;
        private System.Windows.Forms.GroupBox TB_Joueur1;
        private System.Windows.Forms.ComboBox CB_Joueur1;
        private System.Windows.Forms.RadioButton RB_Courageux1;
        private System.Windows.Forms.RadioButton RB_Prudent1;
        private System.Windows.Forms.RadioButton RB_Moyen1;
        private System.Windows.Forms.GroupBox GB_Ordinateur1;
        private System.Windows.Forms.GroupBox GB_Ordinateur2;
        private System.Windows.Forms.RadioButton RB_Courageux2;
        private System.Windows.Forms.RadioButton RB_Moyen2;
        private System.Windows.Forms.RadioButton RB_Prudent2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CB_Joueur2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_Compte1;
        private System.Windows.Forms.CheckBox CB_Compte2;
    }
}

