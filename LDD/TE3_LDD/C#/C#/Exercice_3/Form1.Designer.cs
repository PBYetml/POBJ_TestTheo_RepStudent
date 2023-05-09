namespace Exercice_3
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
            this.BtnTest1 = new System.Windows.Forms.Button();
            this.BtnDiviser = new System.Windows.Forms.Button();
            this.BtnAffîcher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtRest = new System.Windows.Forms.TextBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtVali = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnTest1
            // 
            this.BtnTest1.Location = new System.Drawing.Point(300, 35);
            this.BtnTest1.Name = "BtnTest1";
            this.BtnTest1.Size = new System.Drawing.Size(136, 75);
            this.BtnTest1.TabIndex = 0;
            this.BtnTest1.Text = "Test1";
            this.BtnTest1.UseVisualStyleBackColor = true;
            this.BtnTest1.Click += new System.EventHandler(this.BtnTest1_Click);
            // 
            // BtnDiviser
            // 
            this.BtnDiviser.Location = new System.Drawing.Point(300, 145);
            this.BtnDiviser.Name = "BtnDiviser";
            this.BtnDiviser.Size = new System.Drawing.Size(136, 67);
            this.BtnDiviser.TabIndex = 1;
            this.BtnDiviser.Text = "Diviser";
            this.BtnDiviser.UseVisualStyleBackColor = true;
            this.BtnDiviser.Click += new System.EventHandler(this.BtnDiviser_Click);
            // 
            // BtnAffîcher
            // 
            this.BtnAffîcher.Location = new System.Drawing.Point(300, 262);
            this.BtnAffîcher.Name = "BtnAffîcher";
            this.BtnAffîcher.Size = new System.Drawing.Size(136, 74);
            this.BtnAffîcher.TabIndex = 2;
            this.BtnAffîcher.Text = "Afficher";
            this.BtnAffîcher.UseVisualStyleBackColor = true;
            this.BtnAffîcher.Click += new System.EventHandler(this.BtnAffîcher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Val[i]";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Indice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reste";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Résultat";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(47, 35);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(146, 20);
            this.txtValue.TabIndex = 7;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(51, 90);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(146, 20);
            this.txtResult.TabIndex = 8;
            this.txtResult.TextChanged += new System.EventHandler(this.TxtResult_TextChanged);
            // 
            // txtRest
            // 
            this.txtRest.Location = new System.Drawing.Point(47, 192);
            this.txtRest.Name = "txtRest";
            this.txtRest.Size = new System.Drawing.Size(146, 20);
            this.txtRest.TabIndex = 9;
            this.txtRest.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(108, 262);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(146, 20);
            this.txtIndice.TabIndex = 10;
            // 
            // txtVali
            // 
            this.txtVali.Location = new System.Drawing.Point(108, 316);
            this.txtVali.Name = "txtVali";
            this.txtVali.Size = new System.Drawing.Size(146, 20);
            this.txtVali.TabIndex = 11;
            this.txtVali.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 381);
            this.Controls.Add(this.txtVali);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.txtRest);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAffîcher);
            this.Controls.Add(this.BtnDiviser);
            this.Controls.Add(this.BtnTest1);
            this.Name = "Form1";
            this.Text = "Exercice_3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTest1;
        private System.Windows.Forms.Button BtnDiviser;
        private System.Windows.Forms.Button BtnAffîcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtRest;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtVali;
    }
}

