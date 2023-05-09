namespace Exercice_2
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
            this.stPersonnes = new System.Windows.Forms.ListBox();
            this.RueName = new System.Windows.Forms.ComboBox();
            this.rRueNumber = new System.Windows.Forms.NumericUpDown();
            this.NomVille = new System.Windows.Forms.DomainUpDown();
            this.Btn1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rRueNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // stPersonnes
            // 
            this.stPersonnes.FormattingEnabled = true;
            this.stPersonnes.Items.AddRange(new object[] {
            "Jean-Charles Mendes",
            "Jean-Yves Croujat",
            "Jean-Cule tamere",
            "Jean-Jean Jean",
            "Jackes-Ulysse Poutine"});
            this.stPersonnes.Location = new System.Drawing.Point(12, 12);
            this.stPersonnes.Name = "stPersonnes";
            this.stPersonnes.Size = new System.Drawing.Size(120, 95);
            this.stPersonnes.TabIndex = 0;
            this.stPersonnes.SelectedIndexChanged += new System.EventHandler(this.StPersonnes_SelectedIndexChanged);
            // 
            // RueName
            // 
            this.RueName.FormattingEnabled = true;
            this.RueName.Items.AddRange(new object[] {
            "Rue des Pottiers ",
            "Rue st-michelle",
            "Route de geneve ",
            "Rue de la tartiflette "});
            this.RueName.Location = new System.Drawing.Point(162, 17);
            this.RueName.Name = "RueName";
            this.RueName.Size = new System.Drawing.Size(121, 21);
            this.RueName.TabIndex = 1;
            this.RueName.Text = "Rue des Pottiers ";
            this.RueName.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // rRueNumber
            // 
            this.rRueNumber.Location = new System.Drawing.Point(300, 17);
            this.rRueNumber.Name = "rRueNumber";
            this.rRueNumber.Size = new System.Drawing.Size(48, 20);
            this.rRueNumber.TabIndex = 2;
            this.rRueNumber.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // NomVille
            // 
            this.NomVille.Items.Add("1400 Lausanne ");
            this.NomVille.Items.Add("1456 DTC-city");
            this.NomVille.Items.Add("1404 Pully ");
            this.NomVille.Location = new System.Drawing.Point(367, 17);
            this.NomVille.Name = "NomVille";
            this.NomVille.Size = new System.Drawing.Size(120, 20);
            this.NomVille.TabIndex = 3;
            this.NomVille.Text = "1400 Lausanne ";
            this.NomVille.SelectedItemChanged += new System.EventHandler(this.DomainUpDown1_SelectedItemChanged);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(367, 62);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(120, 50);
            this.Btn1.TabIndex = 4;
            this.Btn1.Text = "Composition";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 67);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(502, 129);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.NomVille);
            this.Controls.Add(this.rRueNumber);
            this.Controls.Add(this.RueName);
            this.Controls.Add(this.stPersonnes);
            this.Name = "Form1";
            this.Text = "Exercice 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rRueNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stPersonnes;
        private System.Windows.Forms.ComboBox RueName;
        private System.Windows.Forms.NumericUpDown rRueNumber;
        private System.Windows.Forms.DomainUpDown NomVille;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

