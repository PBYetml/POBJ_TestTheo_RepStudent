namespace Exercice_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTest = new System.Windows.Forms.Button();
            this.TextIn = new System.Windows.Forms.TextBox();
            this.TextOut = new System.Windows.Forms.TextBox();
            this.radBtnCH = new System.Windows.Forms.RadioButton();
            this.radBtnUS = new System.Windows.Forms.RadioButton();
            this.radBtnLS = new System.Windows.Forms.RadioButton();
            this.radBtnJP = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(141, 259);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(210, 35);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Convertir";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextIn
            // 
            this.TextIn.Location = new System.Drawing.Point(30, 267);
            this.TextIn.Name = "TextIn";
            this.TextIn.Size = new System.Drawing.Size(93, 20);
            this.TextIn.TabIndex = 2;
            // 
            // TextOut
            // 
            this.TextOut.Location = new System.Drawing.Point(382, 267);
            this.TextOut.Name = "TextOut";
            this.TextOut.Size = new System.Drawing.Size(100, 20);
            this.TextOut.TabIndex = 3;
            this.TextOut.TextChanged += new System.EventHandler(this.Resultat_TextChanged);
            // 
            // radBtnCH
            // 
            this.radBtnCH.AutoSize = true;
            this.radBtnCH.Location = new System.Drawing.Point(39, 40);
            this.radBtnCH.Name = "radBtnCH";
            this.radBtnCH.Size = new System.Drawing.Size(83, 17);
            this.radBtnCH.TabIndex = 4;
            this.radBtnCH.TabStop = true;
            this.radBtnCH.Text = "FrancSuisse";
            this.radBtnCH.UseVisualStyleBackColor = true;
            this.radBtnCH.CheckedChanged += new System.EventHandler(this.RadBtnCH_CheckedChanged);
            // 
            // radBtnUS
            // 
            this.radBtnUS.AutoSize = true;
            this.radBtnUS.Location = new System.Drawing.Point(39, 76);
            this.radBtnUS.Name = "radBtnUS";
            this.radBtnUS.Size = new System.Drawing.Size(73, 17);
            this.radBtnUS.TabIndex = 5;
            this.radBtnUS.TabStop = true;
            this.radBtnUS.Text = "US dollars";
            this.radBtnUS.UseVisualStyleBackColor = true;
            this.radBtnUS.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radBtnLS
            // 
            this.radBtnLS.AutoSize = true;
            this.radBtnLS.Location = new System.Drawing.Point(39, 110);
            this.radBtnLS.Name = "radBtnLS";
            this.radBtnLS.Size = new System.Drawing.Size(91, 17);
            this.radBtnLS.TabIndex = 6;
            this.radBtnLS.TabStop = true;
            this.radBtnLS.Text = "Livres Sterling";
            this.radBtnLS.UseVisualStyleBackColor = true;
            this.radBtnLS.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radBtnJP
            // 
            this.radBtnJP.AutoSize = true;
            this.radBtnJP.Location = new System.Drawing.Point(39, 153);
            this.radBtnJP.Name = "radBtnJP";
            this.radBtnJP.Size = new System.Drawing.Size(86, 17);
            this.radBtnJP.TabIndex = 7;
            this.radBtnJP.TabStop = true;
            this.radBtnJP.Text = "Yen japonais";
            this.radBtnJP.UseVisualStyleBackColor = true;
            this.radBtnJP.CheckedChanged += new System.EventHandler(this.RadBtnJP_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CH.png");
            this.imageList1.Images.SetKeyName(1, "EN.png");
            this.imageList1.Images.SetKeyName(2, "JP.png");
            this.imageList1.Images.SetKeyName(3, "US.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercice_1.Properties.Resources.CH;
            this.pictureBox1.Location = new System.Drawing.Point(277, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 187);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Montant";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resultat em euro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radBtnJP);
            this.Controls.Add(this.radBtnLS);
            this.Controls.Add(this.radBtnUS);
            this.Controls.Add(this.radBtnCH);
            this.Controls.Add(this.TextOut);
            this.Controls.Add(this.TextIn);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox TextIn;
        private System.Windows.Forms.TextBox TextOut;
        private System.Windows.Forms.RadioButton radBtnCH;
        private System.Windows.Forms.RadioButton radBtnUS;
        private System.Windows.Forms.RadioButton radBtnLS;
        private System.Windows.Forms.RadioButton radBtnJP;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

