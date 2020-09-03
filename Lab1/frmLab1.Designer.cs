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
            this.btnHexa = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnBinaire = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBinaire = new System.Windows.Forms.TextBox();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHexa
            // 
            this.btnHexa.Location = new System.Drawing.Point(237, 298);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(118, 42);
            this.btnHexa.TabIndex = 0;
            this.btnHexa.Text = "Hexadécimal";
            this.btnHexa.UseVisualStyleBackColor = true;
            this.btnHexa.Click += new System.EventHandler(this.btnHexa_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(61, 298);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(118, 42);
            this.btnDecimal.TabIndex = 1;
            this.btnDecimal.Text = "Décimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btnBinaire
            // 
            this.btnBinaire.Location = new System.Drawing.Point(411, 298);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(118, 42);
            this.btnBinaire.TabIndex = 2;
            this.btnBinaire.Text = "Binaire";
            this.btnBinaire.UseVisualStyleBackColor = true;
            this.btnBinaire.Click += new System.EventHandler(this.btnBinaire_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 22);
            this.textBox1.TabIndex = 3;
            // 
            // txtBinaire
            // 
            this.txtBinaire.Enabled = false;
            this.txtBinaire.Location = new System.Drawing.Point(70, 79);
            this.txtBinaire.Name = "txtBinaire";
            this.txtBinaire.Size = new System.Drawing.Size(100, 22);
            this.txtBinaire.TabIndex = 4;
            // 
            // txtHexa
            // 
            this.txtHexa.Enabled = false;
            this.txtHexa.Location = new System.Drawing.Point(246, 79);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.Size = new System.Drawing.Size(100, 22);
            this.txtHexa.TabIndex = 5;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Enabled = false;
            this.txtDecimal.Location = new System.Drawing.Point(420, 79);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 22);
            this.txtDecimal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valeur à convertir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Binaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hexadécimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Décimal";
            // 
            // frmLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.txtBinaire);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBinaire);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnHexa);
            this.Name = "frmLab1";
            this.Text = "Lab 1 Conversion - Amélie Fournier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHexa;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnBinaire;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBinaire;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

