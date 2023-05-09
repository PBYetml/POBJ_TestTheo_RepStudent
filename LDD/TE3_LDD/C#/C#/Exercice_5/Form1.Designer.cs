namespace Exercice_5
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
            this.btncalcul = new System.Windows.Forms.Button();
            this.txtangle = new System.Windows.Forms.TextBox();
            this.btnbit4 = new System.Windows.Forms.Button();
            this.btnbit3 = new System.Windows.Forms.Button();
            this.btnbit2 = new System.Windows.Forms.Button();
            this.btnbit1 = new System.Windows.Forms.Button();
            this.txtsinus = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalcul
            // 
            this.btncalcul.Location = new System.Drawing.Point(42, 37);
            this.btncalcul.Name = "btncalcul";
            this.btncalcul.Size = new System.Drawing.Size(129, 51);
            this.btncalcul.TabIndex = 0;
            this.btncalcul.Text = "Calcul";
            this.btncalcul.UseVisualStyleBackColor = true;
            this.btncalcul.Click += new System.EventHandler(this.Btncalcul_Click);
            // 
            // txtangle
            // 
            this.txtangle.Location = new System.Drawing.Point(255, 68);
            this.txtangle.Name = "txtangle";
            this.txtangle.Size = new System.Drawing.Size(122, 20);
            this.txtangle.TabIndex = 1;
            // 
            // btnbit4
            // 
            this.btnbit4.Location = new System.Drawing.Point(46, 23);
            this.btnbit4.Name = "btnbit4";
            this.btnbit4.Size = new System.Drawing.Size(64, 51);
            this.btnbit4.TabIndex = 2;
            this.btnbit4.Text = "0";
            this.btnbit4.UseVisualStyleBackColor = true;
            this.btnbit4.Click += new System.EventHandler(this.Btnbit4_Click);
            // 
            // btnbit3
            // 
            this.btnbit3.Location = new System.Drawing.Point(139, 23);
            this.btnbit3.Name = "btnbit3";
            this.btnbit3.Size = new System.Drawing.Size(64, 51);
            this.btnbit3.TabIndex = 3;
            this.btnbit3.Text = "0";
            this.btnbit3.UseVisualStyleBackColor = true;
            this.btnbit3.Click += new System.EventHandler(this.Btnbit3_Click);
            // 
            // btnbit2
            // 
            this.btnbit2.Location = new System.Drawing.Point(226, 23);
            this.btnbit2.Name = "btnbit2";
            this.btnbit2.Size = new System.Drawing.Size(64, 51);
            this.btnbit2.TabIndex = 4;
            this.btnbit2.Text = "0";
            this.btnbit2.UseVisualStyleBackColor = true;
            this.btnbit2.Click += new System.EventHandler(this.Btnbit2_Click);
            // 
            // btnbit1
            // 
            this.btnbit1.Location = new System.Drawing.Point(317, 23);
            this.btnbit1.Name = "btnbit1";
            this.btnbit1.Size = new System.Drawing.Size(64, 51);
            this.btnbit1.TabIndex = 5;
            this.btnbit1.Text = "0";
            this.btnbit1.UseVisualStyleBackColor = true;
            this.btnbit1.Click += new System.EventHandler(this.Btnbit1_Click);
            // 
            // txtsinus
            // 
            this.txtsinus.Location = new System.Drawing.Point(400, 68);
            this.txtsinus.Name = "txtsinus";
            this.txtsinus.Size = new System.Drawing.Size(160, 20);
            this.txtsinus.TabIndex = 6;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(437, 39);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(117, 20);
            this.txtresult.TabIndex = 7;
            this.txtresult.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Angle en degrés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sinus";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsinus);
            this.groupBox1.Controls.Add(this.txtangle);
            this.groupBox1.Controls.Add(this.btncalcul);
            this.groupBox1.Location = new System.Drawing.Point(32, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 117);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtresult);
            this.groupBox2.Controls.Add(this.btnbit1);
            this.groupBox2.Controls.Add(this.btnbit2);
            this.groupBox2.Controls.Add(this.btnbit3);
            this.groupBox2.Controls.Add(this.btnbit4);
            this.groupBox2.Location = new System.Drawing.Point(29, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 102);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 293);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Exercice 5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncalcul;
        private System.Windows.Forms.TextBox txtangle;
        private System.Windows.Forms.Button btnbit4;
        private System.Windows.Forms.Button btnbit3;
        private System.Windows.Forms.Button btnbit2;
        private System.Windows.Forms.Button btnbit1;
        private System.Windows.Forms.TextBox txtsinus;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

