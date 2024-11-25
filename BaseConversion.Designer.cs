namespace BinarizeFormApplication
{
    partial class BaseConversion
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
            this.title = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.from_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.to_combo = new System.Windows.Forms.ComboBox();
            this.from_value_text = new System.Windows.Forms.TextBox();
            this.from_base_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.to_base_label = new System.Windows.Forms.Label();
            this.to_value_text = new System.Windows.Forms.TextBox();
            this.convert_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.Appearance.Font = new System.Drawing.Font("Century", 24F);
            this.title.Location = new System.Drawing.Point(92, 17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(388, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Conversion dans les bases";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14F);
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "De la base :";
            // 
            // from_combo
            // 
            this.from_combo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.from_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.from_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.from_combo.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.from_combo.FormatString = "N0";
            this.from_combo.FormattingEnabled = true;
            this.from_combo.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.from_combo.Location = new System.Drawing.Point(165, 86);
            this.from_combo.Name = "from_combo";
            this.from_combo.Size = new System.Drawing.Size(121, 24);
            this.from_combo.TabIndex = 2;
            this.from_combo.SelectedIndexChanged += new System.EventHandler(this.from_combo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14F);
            this.label2.Location = new System.Drawing.Point(300, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "à la base :";
            // 
            // to_combo
            // 
            this.to_combo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.to_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.to_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.to_combo.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.to_combo.FormatString = "N0";
            this.to_combo.FormattingEnabled = true;
            this.to_combo.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.to_combo.Location = new System.Drawing.Point(413, 86);
            this.to_combo.Name = "to_combo";
            this.to_combo.Size = new System.Drawing.Size(121, 24);
            this.to_combo.TabIndex = 4;
            this.to_combo.SelectedIndexChanged += new System.EventHandler(this.to_combo_SelectedIndexChanged);
            // 
            // from_value_text
            // 
            this.from_value_text.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.from_value_text.Location = new System.Drawing.Point(37, 181);
            this.from_value_text.Name = "from_value_text";
            this.from_value_text.Size = new System.Drawing.Size(133, 24);
            this.from_value_text.TabIndex = 5;
            // 
            // from_base_label
            // 
            this.from_base_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.from_base_label.AutoSize = true;
            this.from_base_label.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold);
            this.from_base_label.Location = new System.Drawing.Point(181, 200);
            this.from_base_label.Name = "from_base_label";
            this.from_base_label.Size = new System.Drawing.Size(17, 18);
            this.from_base_label.TabIndex = 6;
            this.from_base_label.Text = "2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14F);
            this.label3.Location = new System.Drawing.Point(250, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "=";
            // 
            // to_base_label
            // 
            this.to_base_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.to_base_label.AutoSize = true;
            this.to_base_label.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold);
            this.to_base_label.Location = new System.Drawing.Point(486, 194);
            this.to_base_label.Name = "to_base_label";
            this.to_base_label.Size = new System.Drawing.Size(17, 18);
            this.to_base_label.TabIndex = 9;
            this.to_base_label.Text = "2";
            // 
            // to_value_text
            // 
            this.to_value_text.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.to_value_text.Location = new System.Drawing.Point(342, 181);
            this.to_value_text.Name = "to_value_text";
            this.to_value_text.ReadOnly = true;
            this.to_value_text.Size = new System.Drawing.Size(133, 24);
            this.to_value_text.TabIndex = 8;
            // 
            // convert_btn
            // 
            this.convert_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.convert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convert_btn.Font = new System.Drawing.Font("Century", 12F);
            this.convert_btn.ForeColor = System.Drawing.Color.Black;
            this.convert_btn.Location = new System.Drawing.Point(440, 278);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(121, 37);
            this.convert_btn.TabIndex = 10;
            this.convert_btn.Text = "Convertir";
            this.convert_btn.UseVisualStyleBackColor = false;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14F);
            this.label4.Location = new System.Drawing.Point(38, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Entrez une valeur entière :";
            // 
            // BaseConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.to_base_label);
            this.Controls.Add(this.to_value_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.from_base_label);
            this.Controls.Add(this.from_value_text);
            this.Controls.Add(this.to_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.from_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BaseConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion dans les bases";
            this.Load += new System.EventHandler(this.BaseConversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox from_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox to_combo;
        private System.Windows.Forms.TextBox from_value_text;
        private System.Windows.Forms.Label from_base_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label to_base_label;
        private System.Windows.Forms.TextBox to_value_text;
        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.Label label4;
    }
}