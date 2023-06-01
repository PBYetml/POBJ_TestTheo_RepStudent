
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
            this.RbSignalSinus.Location = new System.Drawing.Point(33, 28);
            this.RbSignalSinus.Name = "RbSignalSinus";
            this.RbSignalSinus.Size = new System.Drawing.Size(85, 17);
            this.RbSignalSinus.TabIndex = 0;
            this.RbSignalSinus.TabStop = true;
            this.RbSignalSinus.Text = "radioButton1";
            this.RbSignalSinus.UseVisualStyleBackColor = true;
            this.RbSignalSinus.CheckedChanged += new System.EventHandler(this.RbSignalSinus_CheckedChanged);
            // 
            // RbSignalTTL
            // 
            this.RbSignalTTL.AutoSize = true;
            this.RbSignalTTL.Location = new System.Drawing.Point(33, 51);
            this.RbSignalTTL.Name = "RbSignalTTL";
            this.RbSignalTTL.Size = new System.Drawing.Size(85, 17);
            this.RbSignalTTL.TabIndex = 1;
            this.RbSignalTTL.TabStop = true;
            this.RbSignalTTL.Text = "radioButton2";
            this.RbSignalTTL.UseVisualStyleBackColor = true;
            this.RbSignalTTL.CheckedChanged += new System.EventHandler(this.RbSignalTTL_CheckedChanged);
            // 
            // CbOffset
            // 
            this.CbOffset.AutoSize = true;
            this.CbOffset.Location = new System.Drawing.Point(139, 29);
            this.CbOffset.Name = "CbOffset";
            this.CbOffset.Size = new System.Drawing.Size(80, 17);
            this.CbOffset.TabIndex = 2;
            this.CbOffset.Text = "checkBox1";
            this.CbOffset.UseVisualStyleBackColor = true;
            this.CbOffset.CheckedChanged += new System.EventHandler(this.CbOffset_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 139);
            this.Controls.Add(this.CbOffset);
            this.Controls.Add(this.RbSignalTTL);
            this.Controls.Add(this.RbSignalSinus);
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

