
namespace Test2S3_Q3
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
            this.RbSignalSinus = new System.Windows.Forms.RadioButton();
            this.RbSignalTTL = new System.Windows.Forms.RadioButton();
            this.CbOffset = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // RbSignalSinus
            // 
            this.RbSignalSinus.AutoSize = true;
            this.RbSignalSinus.Location = new System.Drawing.Point(66, 54);
            this.RbSignalSinus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RbSignalSinus.Name = "RbSignalSinus";
            this.RbSignalSinus.Size = new System.Drawing.Size(165, 29);
            this.RbSignalSinus.TabIndex = 0;
            this.RbSignalSinus.TabStop = true;
            this.RbSignalSinus.Text = "radioButton1";
            this.RbSignalSinus.UseVisualStyleBackColor = true;
            // 
            // RbSignalTTL
            // 
            this.RbSignalTTL.AutoSize = true;
            this.RbSignalTTL.Location = new System.Drawing.Point(66, 98);
            this.RbSignalTTL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RbSignalTTL.Name = "RbSignalTTL";
            this.RbSignalTTL.Size = new System.Drawing.Size(165, 29);
            this.RbSignalTTL.TabIndex = 1;
            this.RbSignalTTL.TabStop = true;
            this.RbSignalTTL.Text = "radioButton2";
            this.RbSignalTTL.UseVisualStyleBackColor = true;
            // 
            // CbOffset
            // 
            this.CbOffset.AutoSize = true;
            this.CbOffset.Location = new System.Drawing.Point(278, 56);
            this.CbOffset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CbOffset.Name = "CbOffset";
            this.CbOffset.Size = new System.Drawing.Size(150, 29);
            this.CbOffset.TabIndex = 2;
            this.CbOffset.Text = "checkBox1";
            this.CbOffset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 267);
            this.Controls.Add(this.CbOffset);
            this.Controls.Add(this.RbSignalTTL);
            this.Controls.Add(this.RbSignalSinus);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbSignalSinus;
        private System.Windows.Forms.RadioButton RbSignalTTL;
        private System.Windows.Forms.CheckBox CbOffset;
    }
}

