namespace BinarizeFormApplication
{
    partial class FloatDecimal
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
            this.nb_bits = new System.Windows.Forms.TextBox();
            this.label_nb_bits = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.convert_btn = new System.Windows.Forms.Button();
            this.smallest_numbers = new System.Windows.Forms.Label();
            this.biggest_numbers = new System.Windows.Forms.Label();
            this.dpart_information = new System.Windows.Forms.Label();
            this.epart_information = new System.Windows.Forms.Label();
            this.sign_information = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.to_base_label = new System.Windows.Forms.Label();
            this.to_value_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.from_base_label = new System.Windows.Forms.Label();
            this.from_value_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conversion_type = new System.Windows.Forms.ComboBox();
            this.title = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // nb_bits
            // 
            this.nb_bits.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.nb_bits.Location = new System.Drawing.Point(300, 216);
            this.nb_bits.Name = "nb_bits";
            this.nb_bits.Size = new System.Drawing.Size(171, 24);
            this.nb_bits.TabIndex = 48;
            this.nb_bits.Text = "2";
            this.nb_bits.Visible = false;
            // 
            // label_nb_bits
            // 
            this.label_nb_bits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_nb_bits.AutoSize = true;
            this.label_nb_bits.Font = new System.Drawing.Font("Century", 11F);
            this.label_nb_bits.Location = new System.Drawing.Point(29, 217);
            this.label_nb_bits.Name = "label_nb_bits";
            this.label_nb_bits.Size = new System.Drawing.Size(265, 18);
            this.label_nb_bits.TabIndex = 47;
            this.label_nb_bits.Text = "Bits après la virgule (entre 2 et 20) : ";
            this.label_nb_bits.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Convention (X)_y : X en base y";
            // 
            // convert_btn
            // 
            this.convert_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.convert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convert_btn.Font = new System.Drawing.Font("Century", 12F);
            this.convert_btn.ForeColor = System.Drawing.Color.Black;
            this.convert_btn.Location = new System.Drawing.Point(433, 518);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(121, 37);
            this.convert_btn.TabIndex = 45;
            this.convert_btn.Text = "Convertir";
            this.convert_btn.UseVisualStyleBackColor = false;
            // 
            // smallest_numbers
            // 
            this.smallest_numbers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.smallest_numbers.AutoSize = true;
            this.smallest_numbers.Font = new System.Drawing.Font("Century", 10F);
            this.smallest_numbers.Location = new System.Drawing.Point(30, 460);
            this.smallest_numbers.Name = "smallest_numbers";
            this.smallest_numbers.Size = new System.Drawing.Size(17, 17);
            this.smallest_numbers.TabIndex = 44;
            this.smallest_numbers.Text = "- ";
            // 
            // biggest_numbers
            // 
            this.biggest_numbers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.biggest_numbers.AutoSize = true;
            this.biggest_numbers.Font = new System.Drawing.Font("Century", 10F);
            this.biggest_numbers.Location = new System.Drawing.Point(30, 426);
            this.biggest_numbers.Name = "biggest_numbers";
            this.biggest_numbers.Size = new System.Drawing.Size(17, 17);
            this.biggest_numbers.TabIndex = 43;
            this.biggest_numbers.Text = "- ";
            // 
            // dpart_information
            // 
            this.dpart_information.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpart_information.AutoSize = true;
            this.dpart_information.Font = new System.Drawing.Font("Century", 10F);
            this.dpart_information.Location = new System.Drawing.Point(30, 364);
            this.dpart_information.Name = "dpart_information";
            this.dpart_information.Size = new System.Drawing.Size(17, 17);
            this.dpart_information.TabIndex = 42;
            this.dpart_information.Text = "- ";
            // 
            // epart_information
            // 
            this.epart_information.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.epart_information.AutoSize = true;
            this.epart_information.Font = new System.Drawing.Font("Century", 10F);
            this.epart_information.Location = new System.Drawing.Point(30, 330);
            this.epart_information.Name = "epart_information";
            this.epart_information.Size = new System.Drawing.Size(17, 17);
            this.epart_information.TabIndex = 41;
            this.epart_information.Text = "- ";
            // 
            // sign_information
            // 
            this.sign_information.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sign_information.AutoSize = true;
            this.sign_information.Font = new System.Drawing.Font("Century", 10F);
            this.sign_information.Location = new System.Drawing.Point(30, 293);
            this.sign_information.Name = "sign_information";
            this.sign_information.Size = new System.Drawing.Size(17, 17);
            this.sign_information.TabIndex = 40;
            this.sign_information.Text = "- ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14F);
            this.label2.Location = new System.Drawing.Point(28, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Informations supplémentaires : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14F);
            this.label4.Location = new System.Drawing.Point(35, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Entrez une valeur :";
            // 
            // to_base_label
            // 
            this.to_base_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.to_base_label.AutoSize = true;
            this.to_base_label.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold);
            this.to_base_label.Location = new System.Drawing.Point(523, 183);
            this.to_base_label.Name = "to_base_label";
            this.to_base_label.Size = new System.Drawing.Size(17, 18);
            this.to_base_label.TabIndex = 37;
            this.to_base_label.Text = "2";
            // 
            // to_value_text
            // 
            this.to_value_text.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.to_value_text.Location = new System.Drawing.Point(346, 165);
            this.to_value_text.Name = "to_value_text";
            this.to_value_text.ReadOnly = true;
            this.to_value_text.Size = new System.Drawing.Size(171, 24);
            this.to_value_text.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14F);
            this.label3.Location = new System.Drawing.Point(293, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "=";
            // 
            // from_base_label
            // 
            this.from_base_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.from_base_label.AutoSize = true;
            this.from_base_label.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold);
            this.from_base_label.Location = new System.Drawing.Point(230, 183);
            this.from_base_label.Name = "from_base_label";
            this.from_base_label.Size = new System.Drawing.Size(17, 18);
            this.from_base_label.TabIndex = 34;
            this.from_base_label.Text = "2";
            // 
            // from_value_text
            // 
            this.from_value_text.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.from_value_text.Location = new System.Drawing.Point(53, 164);
            this.from_value_text.Name = "from_value_text";
            this.from_value_text.Size = new System.Drawing.Size(171, 24);
            this.from_value_text.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14F);
            this.label1.Location = new System.Drawing.Point(66, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Type de conversion :";
            // 
            // conversion_type
            // 
            this.conversion_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.conversion_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conversion_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.conversion_type.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.conversion_type.FormatString = "N0";
            this.conversion_type.FormattingEnabled = true;
            this.conversion_type.Items.AddRange(new object[] {
            "Base 2 vers base 10",
            "Base 10 vers base 2"});
            this.conversion_type.Location = new System.Drawing.Point(262, 86);
            this.conversion_type.Name = "conversion_type";
            this.conversion_type.Size = new System.Drawing.Size(255, 24);
            this.conversion_type.TabIndex = 31;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.Appearance.Font = new System.Drawing.Font("Century", 24F);
            this.title.Location = new System.Drawing.Point(31, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(520, 38);
            this.title.TabIndex = 30;
            this.title.Text = "Représentation en virgule flottante";
            // 
            // FloatDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 574);
            this.Controls.Add(this.nb_bits);
            this.Controls.Add(this.label_nb_bits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.smallest_numbers);
            this.Controls.Add(this.biggest_numbers);
            this.Controls.Add(this.dpart_information);
            this.Controls.Add(this.epart_information);
            this.Controls.Add(this.sign_information);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.to_base_label);
            this.Controls.Add(this.to_value_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.from_base_label);
            this.Controls.Add(this.from_value_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conversion_type);
            this.Controls.Add(this.title);
            this.Name = "FloatDecimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Représentation en virgule flottante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nb_bits;
        private System.Windows.Forms.Label label_nb_bits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.Label smallest_numbers;
        private System.Windows.Forms.Label biggest_numbers;
        private System.Windows.Forms.Label dpart_information;
        private System.Windows.Forms.Label epart_information;
        private System.Windows.Forms.Label sign_information;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label to_base_label;
        private System.Windows.Forms.TextBox to_value_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label from_base_label;
        private System.Windows.Forms.TextBox from_value_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox conversion_type;
        private DevExpress.XtraEditors.LabelControl title;

    }
}