
namespace CS_Exercice_1
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.rbnCHF = new System.Windows.Forms.RadioButton();
            this.rbnUSD = new System.Windows.Forms.RadioButton();
            this.rbnGBP = new System.Windows.Forms.RadioButton();
            this.rbnYEN = new System.Windows.Forms.RadioButton();
            this.picDevise = new System.Windows.Forms.PictureBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtResultat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDevise)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(184, 287);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(120, 50);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbnCHF
            // 
            this.rbnCHF.AutoSize = true;
            this.rbnCHF.Location = new System.Drawing.Point(37, 41);
            this.rbnCHF.Name = "rbnCHF";
            this.rbnCHF.Size = new System.Drawing.Size(91, 17);
            this.rbnCHF.TabIndex = 1;
            this.rbnCHF.TabStop = true;
            this.rbnCHF.Text = "Francs Suisse";
            this.rbnCHF.UseVisualStyleBackColor = true;
            this.rbnCHF.CheckedChanged += new System.EventHandler(this.rbnCHF_CheckedChanged);
            // 
            // rbnUSD
            // 
            this.rbnUSD.AutoSize = true;
            this.rbnUSD.Location = new System.Drawing.Point(37, 73);
            this.rbnUSD.Name = "rbnUSD";
            this.rbnUSD.Size = new System.Drawing.Size(75, 17);
            this.rbnUSD.TabIndex = 2;
            this.rbnUSD.TabStop = true;
            this.rbnUSD.Text = "US Dollars";
            this.rbnUSD.UseVisualStyleBackColor = true;
            this.rbnUSD.CheckedChanged += new System.EventHandler(this.rbnUSD_CheckedChanged);
            // 
            // rbnGBP
            // 
            this.rbnGBP.AutoSize = true;
            this.rbnGBP.Location = new System.Drawing.Point(37, 105);
            this.rbnGBP.Name = "rbnGBP";
            this.rbnGBP.Size = new System.Drawing.Size(91, 17);
            this.rbnGBP.TabIndex = 3;
            this.rbnGBP.TabStop = true;
            this.rbnGBP.Text = "Livres Sterling";
            this.rbnGBP.UseVisualStyleBackColor = true;
            this.rbnGBP.CheckedChanged += new System.EventHandler(this.rbnGBP_CheckedChanged);
            // 
            // rbnYEN
            // 
            this.rbnYEN.AutoSize = true;
            this.rbnYEN.Location = new System.Drawing.Point(37, 137);
            this.rbnYEN.Name = "rbnYEN";
            this.rbnYEN.Size = new System.Drawing.Size(89, 17);
            this.rbnYEN.TabIndex = 4;
            this.rbnYEN.TabStop = true;
            this.rbnYEN.Text = "Yen Japonais";
            this.rbnYEN.UseVisualStyleBackColor = true;
            this.rbnYEN.CheckedChanged += new System.EventHandler(this.rbnYEN_CheckedChanged);
            // 
            // picDevise
            // 
            this.picDevise.Image = global::CS_Exercice_1.Properties.Resources.Flag_of_Switzerland;
            this.picDevise.Location = new System.Drawing.Point(159, 12);
            this.picDevise.Name = "picDevise";
            this.picDevise.Size = new System.Drawing.Size(299, 227);
            this.picDevise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDevise.TabIndex = 5;
            this.picDevise.TabStop = false;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(37, 303);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 6;
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(358, 303);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(100, 20);
            this.txtResultat.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 351);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.picDevise);
            this.Controls.Add(this.rbnYEN);
            this.Controls.Add(this.rbnGBP);
            this.Controls.Add(this.rbnUSD);
            this.Controls.Add(this.rbnCHF);
            this.Controls.Add(this.btnConvertir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDevise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.RadioButton rbnCHF;
        private System.Windows.Forms.RadioButton rbnUSD;
        private System.Windows.Forms.RadioButton rbnGBP;
        private System.Windows.Forms.RadioButton rbnYEN;
        private System.Windows.Forms.PictureBox picDevise;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtResultat;
    }
}

