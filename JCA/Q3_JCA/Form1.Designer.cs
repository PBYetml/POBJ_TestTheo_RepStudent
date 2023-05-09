namespace Q3
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
            this.rbSignalSinus = new System.Windows.Forms.RadioButton();
            this.rbSignalTTL = new System.Windows.Forms.RadioButton();
            this.cbOffset = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rbSignalSinus
            // 
            this.rbSignalSinus.AccessibleName = "";
            this.rbSignalSinus.AutoSize = true;
            this.rbSignalSinus.Location = new System.Drawing.Point(93, 64);
            this.rbSignalSinus.Name = "rbSignalSinus";
            this.rbSignalSinus.Size = new System.Drawing.Size(85, 17);
            this.rbSignalSinus.TabIndex = 0;
            this.rbSignalSinus.TabStop = true;
            this.rbSignalSinus.Text = "radioButton1";
            this.rbSignalSinus.UseVisualStyleBackColor = true;
            this.rbSignalSinus.CheckedChanged += new System.EventHandler(this.RbSignalSinus_CheckedChanged);
            // 
            // rbSignalTTL
            // 
            this.rbSignalTTL.AccessibleName = "";
            this.rbSignalTTL.AutoSize = true;
            this.rbSignalTTL.Location = new System.Drawing.Point(93, 106);
            this.rbSignalTTL.Name = "rbSignalTTL";
            this.rbSignalTTL.Size = new System.Drawing.Size(85, 17);
            this.rbSignalTTL.TabIndex = 1;
            this.rbSignalTTL.TabStop = true;
            this.rbSignalTTL.Text = "radioButton2";
            this.rbSignalTTL.UseVisualStyleBackColor = true;
            // 
            // cbOffset
            // 
            this.cbOffset.AccessibleName = "";
            this.cbOffset.AutoSize = true;
            this.cbOffset.Location = new System.Drawing.Point(218, 65);
            this.cbOffset.Name = "cbOffset";
            this.cbOffset.Size = new System.Drawing.Size(80, 17);
            this.cbOffset.TabIndex = 2;
            this.cbOffset.Text = "checkBox1";
            this.cbOffset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbOffset);
            this.Controls.Add(this.rbSignalTTL);
            this.Controls.Add(this.rbSignalSinus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSignalSinus;
        private System.Windows.Forms.RadioButton rbSignalTTL;
        private System.Windows.Forms.CheckBox cbOffset;
    }
}

