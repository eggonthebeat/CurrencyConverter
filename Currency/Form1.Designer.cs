
namespace Currency
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
            this.convertBtn = new System.Windows.Forms.Button();
            this.currency1Box = new System.Windows.Forms.ComboBox();
            this.currency2Box = new System.Windows.Forms.ComboBox();
            this.currency1txt = new System.Windows.Forms.TextBox();
            this.currency2txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(162, 163);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 0;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // currency1Box
            // 
            this.currency1Box.FormattingEnabled = true;
            this.currency1Box.Items.AddRange(new object[] {
            "SEK",
            "USD",
            "NOK",
            "YEN"});
            this.currency1Box.Location = new System.Drawing.Point(55, 136);
            this.currency1Box.Name = "currency1Box";
            this.currency1Box.Size = new System.Drawing.Size(121, 21);
            this.currency1Box.TabIndex = 1;
            this.currency1Box.Text = "SEK";
            // 
            // currency2Box
            // 
            this.currency2Box.FormattingEnabled = true;
            this.currency2Box.Items.AddRange(new object[] {
            "NOK",
            "USD",
            "SEK",
            "YEN"});
            this.currency2Box.Location = new System.Drawing.Point(222, 136);
            this.currency2Box.Name = "currency2Box";
            this.currency2Box.Size = new System.Drawing.Size(121, 21);
            this.currency2Box.TabIndex = 1;
            this.currency2Box.Text = "NOK";
            this.currency2Box.SelectedIndexChanged += new System.EventHandler(this.currency2Box_SelectedIndexChanged);
            // 
            // currency1txt
            // 
            this.currency1txt.Location = new System.Drawing.Point(55, 110);
            this.currency1txt.Name = "currency1txt";
            this.currency1txt.Size = new System.Drawing.Size(121, 20);
            this.currency1txt.TabIndex = 2;
            // 
            // currency2txt
            // 
            this.currency2txt.Location = new System.Drawing.Point(222, 110);
            this.currency2txt.Name = "currency2txt";
            this.currency2txt.Size = new System.Drawing.Size(121, 20);
            this.currency2txt.TabIndex = 2;
            this.currency2txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "CURRENCY CONVERTER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Currency.Properties.Resources.Arrow_east_svg;
            this.pictureBox1.Location = new System.Drawing.Point(182, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 258);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currency2txt);
            this.Controls.Add(this.currency1txt);
            this.Controls.Add(this.currency2Box);
            this.Controls.Add(this.currency1Box);
            this.Controls.Add(this.convertBtn);
            this.Name = "Form1";
            this.Text = "CC - Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.ComboBox currency1Box;
        private System.Windows.Forms.ComboBox currency2Box;
        private System.Windows.Forms.TextBox currency1txt;
        private System.Windows.Forms.TextBox currency2txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

