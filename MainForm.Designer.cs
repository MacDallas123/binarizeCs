namespace BinarizeFormApplication
{
    partial class MainForm
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
            this.close_btn = new System.Windows.Forms.Button();
            this.base_conversion_btn = new System.Windows.Forms.Button();
            this.flot_rep_btn = new System.Windows.Forms.Button();
            this.fix_rep_btn = new System.Windows.Forms.Button();
            this.norm_rep_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_btn.Location = new System.Drawing.Point(3, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(44, 44);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // base_conversion_btn
            // 
            this.base_conversion_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.base_conversion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.base_conversion_btn.Font = new System.Drawing.Font("Century", 14F);
            this.base_conversion_btn.Location = new System.Drawing.Point(123, 82);
            this.base_conversion_btn.Name = "base_conversion_btn";
            this.base_conversion_btn.Size = new System.Drawing.Size(292, 47);
            this.base_conversion_btn.TabIndex = 1;
            this.base_conversion_btn.Text = "Conversion dans les bases";
            this.base_conversion_btn.UseVisualStyleBackColor = false;
            this.base_conversion_btn.Click += new System.EventHandler(this.base_conversion_btn_Click);
            // 
            // flot_rep_btn
            // 
            this.flot_rep_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.flot_rep_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flot_rep_btn.Font = new System.Drawing.Font("Century", 12F);
            this.flot_rep_btn.Location = new System.Drawing.Point(123, 210);
            this.flot_rep_btn.Name = "flot_rep_btn";
            this.flot_rep_btn.Size = new System.Drawing.Size(292, 47);
            this.flot_rep_btn.TabIndex = 3;
            this.flot_rep_btn.Text = "Représentation en virgule flottante";
            this.flot_rep_btn.UseVisualStyleBackColor = false;
            this.flot_rep_btn.Click += new System.EventHandler(this.flot_rep_btn_Click);
            // 
            // fix_rep_btn
            // 
            this.fix_rep_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.fix_rep_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fix_rep_btn.Font = new System.Drawing.Font("Century", 14F);
            this.fix_rep_btn.Location = new System.Drawing.Point(123, 146);
            this.fix_rep_btn.Name = "fix_rep_btn";
            this.fix_rep_btn.Size = new System.Drawing.Size(292, 47);
            this.fix_rep_btn.TabIndex = 2;
            this.fix_rep_btn.Text = "Représentation en virgule fixe";
            this.fix_rep_btn.UseVisualStyleBackColor = false;
            this.fix_rep_btn.Click += new System.EventHandler(this.fix_rep_btn_Click);
            // 
            // norm_rep_btn
            // 
            this.norm_rep_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.norm_rep_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.norm_rep_btn.Font = new System.Drawing.Font("Century", 14F);
            this.norm_rep_btn.Location = new System.Drawing.Point(123, 274);
            this.norm_rep_btn.Name = "norm_rep_btn";
            this.norm_rep_btn.Size = new System.Drawing.Size(292, 47);
            this.norm_rep_btn.TabIndex = 4;
            this.norm_rep_btn.Text = "Norme IEEE 754";
            this.norm_rep_btn.UseVisualStyleBackColor = false;
            this.norm_rep_btn.Click += new System.EventHandler(this.norm_rep_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BinarizeFormApplication.Properties.Resources._1_50px;
            this.pictureBox1.Location = new System.Drawing.Point(51, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 47);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BinarizeFormApplication.Properties.Resources._2_50px;
            this.pictureBox2.Location = new System.Drawing.Point(51, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 47);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BinarizeFormApplication.Properties.Resources._3_50px;
            this.pictureBox3.Location = new System.Drawing.Point(51, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 47);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BinarizeFormApplication.Properties.Resources._4_50px;
            this.pictureBox4.Location = new System.Drawing.Point(51, 274);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 47);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 28F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Binarize v1.0";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(113)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.norm_rep_btn);
            this.Controls.Add(this.flot_rep_btn);
            this.Controls.Add(this.fix_rep_btn);
            this.Controls.Add(this.base_conversion_btn);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button base_conversion_btn;
        private System.Windows.Forms.Button flot_rep_btn;
        private System.Windows.Forms.Button fix_rep_btn;
        private System.Windows.Forms.Button norm_rep_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;

    }
}

