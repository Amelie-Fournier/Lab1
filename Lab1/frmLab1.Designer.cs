namespace Lab1
{
    partial class frmLab1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAffiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAffiche
            // 
            this.btnAffiche.Location = new System.Drawing.Point(336, 208);
            this.btnAffiche.Name = "btnAffiche";
            this.btnAffiche.Size = new System.Drawing.Size(135, 23);
            this.btnAffiche.TabIndex = 0;
            this.btnAffiche.Text = "btnAffiche";
            this.btnAffiche.UseVisualStyleBackColor = true;
            this.btnAffiche.Click += new System.EventHandler(this.btnAffiche_Click);
            // 
            // frmLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAffiche);
            this.Name = "frmLab1";
            this.Text = "Lab 1 Conversion - Amélie Fournier";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAffiche;
    }
}

