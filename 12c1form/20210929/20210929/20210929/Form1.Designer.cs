namespace _20210929
{
    partial class Form1
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
            this.lblhonap = new System.Windows.Forms.Label();
            this.txtsorszam = new System.Windows.Forms.TextBox();
            this.lblevszak = new System.Windows.Forms.Label();
            this.btnevszak = new System.Windows.Forms.Button();
            this.btnkilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhonap
            // 
            this.lblhonap.AutoSize = true;
            this.lblhonap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblhonap.Location = new System.Drawing.Point(7, 30);
            this.lblhonap.Name = "lblhonap";
            this.lblhonap.Size = new System.Drawing.Size(129, 16);
            this.lblhonap.TabIndex = 0;
            this.lblhonap.Text = "Hónapok sorszáma:";
            // 
            // txtsorszam
            // 
            this.txtsorszam.Location = new System.Drawing.Point(142, 26);
            this.txtsorszam.Name = "txtsorszam";
            this.txtsorszam.Size = new System.Drawing.Size(100, 20);
            this.txtsorszam.TabIndex = 1;
            this.txtsorszam.TextChanged += new System.EventHandler(this.Txtsorszam_TextChanged);
            // 
            // lblevszak
            // 
            this.lblevszak.AutoSize = true;
            this.lblevszak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblevszak.Location = new System.Drawing.Point(93, 96);
            this.lblevszak.Name = "lblevszak";
            this.lblevszak.Size = new System.Drawing.Size(48, 13);
            this.lblevszak.TabIndex = 2;
            this.lblevszak.Text = "Évszak";
            // 
            // btnevszak
            // 
            this.btnevszak.Location = new System.Drawing.Point(12, 208);
            this.btnevszak.Name = "btnevszak";
            this.btnevszak.Size = new System.Drawing.Size(75, 23);
            this.btnevszak.TabIndex = 3;
            this.btnevszak.Text = "Évszak";
            this.btnevszak.UseVisualStyleBackColor = true;
            this.btnevszak.Click += new System.EventHandler(this.Btnevszak_Click);
            // 
            // btnkilep
            // 
            this.btnkilep.Location = new System.Drawing.Point(167, 208);
            this.btnkilep.Name = "btnkilep";
            this.btnkilep.Size = new System.Drawing.Size(75, 23);
            this.btnkilep.TabIndex = 4;
            this.btnkilep.Text = "Kilépés";
            this.btnkilep.UseVisualStyleBackColor = true;
            this.btnkilep.Click += new System.EventHandler(this.Btnkilep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(254, 243);
            this.Controls.Add(this.btnkilep);
            this.Controls.Add(this.btnevszak);
            this.Controls.Add(this.lblevszak);
            this.Controls.Add(this.txtsorszam);
            this.Controls.Add(this.lblhonap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhonap;
        private System.Windows.Forms.TextBox txtsorszam;
        private System.Windows.Forms.Label lblevszak;
        private System.Windows.Forms.Button btnevszak;
        private System.Windows.Forms.Button btnkilep;
    }
}

