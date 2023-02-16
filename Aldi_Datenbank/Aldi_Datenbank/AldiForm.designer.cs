namespace XML_Schreiben_SamedTrnka_
{
    partial class AldiForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AldiForm));
            this.tbxFilialenNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbxPosition = new System.Windows.Forms.CheckedListBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.rbtnMan = new System.Windows.Forms.RadioButton();
            this.rbtnWoman = new System.Windows.Forms.RadioButton();
            this.tbxVorname = new System.Windows.Forms.TextBox();
            this.tbxNachname = new System.Windows.Forms.TextBox();
            this.tbxMitarbeiterNr = new System.Windows.Forms.TextBox();
            this.tbxVertrag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnOthers = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxFilialenNr
            // 
            this.tbxFilialenNr.Location = new System.Drawing.Point(58, 175);
            this.tbxFilialenNr.Name = "tbxFilialenNr";
            this.tbxFilialenNr.Size = new System.Drawing.Size(168, 20);
            this.tbxFilialenNr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filialen Nr:";
            // 
            // clbxPosition
            // 
            this.clbxPosition.FormattingEnabled = true;
            this.clbxPosition.Items.AddRange(new object[] {
            "Verkaufsleiter",
            "Regionalverkaufsleiter",
            "Filialverantwortlicher",
            "Mitarbeiter",
            "Aushilfe"});
            this.clbxPosition.Location = new System.Drawing.Point(58, 244);
            this.clbxPosition.Name = "clbxPosition";
            this.clbxPosition.Size = new System.Drawing.Size(168, 124);
            this.clbxPosition.TabIndex = 2;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(227, 384);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(123, 37);
            this.btnSpeichern.TabIndex = 3;
            this.btnSpeichern.Text = "Suchen";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
            // 
            // rbtnMan
            // 
            this.rbtnMan.AutoSize = true;
            this.rbtnMan.Location = new System.Drawing.Point(242, 176);
            this.rbtnMan.Name = "rbtnMan";
            this.rbtnMan.Size = new System.Drawing.Size(68, 17);
            this.rbtnMan.TabIndex = 4;
            this.rbtnMan.TabStop = true;
            this.rbtnMan.Text = "Männlich";
            this.rbtnMan.UseVisualStyleBackColor = true;
            // 
            // rbtnWoman
            // 
            this.rbtnWoman.AutoSize = true;
            this.rbtnWoman.Location = new System.Drawing.Point(242, 199);
            this.rbtnWoman.Name = "rbtnWoman";
            this.rbtnWoman.Size = new System.Drawing.Size(66, 17);
            this.rbtnWoman.TabIndex = 5;
            this.rbtnWoman.TabStop = true;
            this.rbtnWoman.Text = "Weiblich";
            this.rbtnWoman.UseVisualStyleBackColor = true;
            // 
            // tbxVorname
            // 
            this.tbxVorname.Location = new System.Drawing.Point(58, 134);
            this.tbxVorname.Name = "tbxVorname";
            this.tbxVorname.Size = new System.Drawing.Size(168, 20);
            this.tbxVorname.TabIndex = 6;
            // 
            // tbxNachname
            // 
            this.tbxNachname.Location = new System.Drawing.Point(242, 134);
            this.tbxNachname.Name = "tbxNachname";
            this.tbxNachname.Size = new System.Drawing.Size(168, 20);
            this.tbxNachname.TabIndex = 7;
            // 
            // tbxMitarbeiterNr
            // 
            this.tbxMitarbeiterNr.Location = new System.Drawing.Point(58, 62);
            this.tbxMitarbeiterNr.Name = "tbxMitarbeiterNr";
            this.tbxMitarbeiterNr.Size = new System.Drawing.Size(168, 20);
            this.tbxMitarbeiterNr.TabIndex = 8;
            // 
            // tbxVertrag
            // 
            this.tbxVertrag.Location = new System.Drawing.Point(58, 218);
            this.tbxVertrag.Name = "tbxVertrag";
            this.tbxVertrag.Size = new System.Drawing.Size(168, 20);
            this.tbxVertrag.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vorname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nachname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mitarbeiter Nr:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vertragstyp:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(98, 384);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 37);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Löschen";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 116);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnOthers
            // 
            this.rbtnOthers.AutoSize = true;
            this.rbtnOthers.Location = new System.Drawing.Point(242, 222);
            this.rbtnOthers.Name = "rbtnOthers";
            this.rbtnOthers.Size = new System.Drawing.Size(59, 17);
            this.rbtnOthers.TabIndex = 17;
            this.rbtnOthers.TabStop = true;
            this.rbtnOthers.Text = "Andere";
            this.rbtnOthers.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Suche:";
            // 
            // AldiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbtnOthers);
            this.Controls.Add(this.rbtnMan);
            this.Controls.Add(this.rbtnWoman);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxVertrag);
            this.Controls.Add(this.tbxMitarbeiterNr);
            this.Controls.Add(this.tbxNachname);
            this.Controls.Add(this.tbxVorname);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.clbxPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFilialenNr);
            this.Name = "AldiForm";
            this.Text = "Aldi-Süd Mitarbeiter System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFilialenNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbxPosition;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.RadioButton rbtnMan;
        private System.Windows.Forms.RadioButton rbtnWoman;
        private System.Windows.Forms.TextBox tbxVorname;
        private System.Windows.Forms.TextBox tbxNachname;
        private System.Windows.Forms.TextBox tbxMitarbeiterNr;
        private System.Windows.Forms.TextBox tbxVertrag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnOthers;
        private System.Windows.Forms.Label label6;
    }
}

