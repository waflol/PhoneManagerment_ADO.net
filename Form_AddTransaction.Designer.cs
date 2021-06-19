
namespace PhoneManagerment_ADO.net
{
    partial class Form_AddTransaction
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
            this.Name_Label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Phone_Number_Label = new System.Windows.Forms.Label();
            this.PhoneName_Label = new System.Windows.Forms.Label();
            this.Quantity_Label = new System.Windows.Forms.Label();
            this.Customer_Panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Phone_Number_Textbox = new System.Windows.Forms.TextBox();
            this.Address_Textbox = new System.Windows.Forms.TextBox();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Customer_Inf_Label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_camera = new System.Windows.Forms.TextBox();
            this.txt_sim = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Display = new System.Windows.Forms.TextBox();
            this.txt_istorage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Ram = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_PhoneName = new System.Windows.Forms.ComboBox();
            this.Add_Phone_Button = new System.Windows.Forms.Button();
            this.Phone_Inf_Label = new System.Windows.Forms.Label();
            this.numeric_Quantity = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Total_Price_Label = new System.Windows.Forms.Label();
            this.Total_Price_Textbox = new System.Windows.Forms.TextBox();
            this.Export_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.Color.Blue;
            this.Name_Label.Location = new System.Drawing.Point(23, 52);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(47, 13);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name :";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_Label.ForeColor = System.Drawing.Color.Blue;
            this.Address_Label.Location = new System.Drawing.Point(10, 83);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(60, 13);
            this.Address_Label.TabIndex = 1;
            this.Address_Label.Text = "Address :";
            // 
            // Phone_Number_Label
            // 
            this.Phone_Number_Label.AutoSize = true;
            this.Phone_Number_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Number_Label.ForeColor = System.Drawing.Color.Blue;
            this.Phone_Number_Label.Location = new System.Drawing.Point(34, 115);
            this.Phone_Number_Label.Name = "Phone_Number_Label";
            this.Phone_Number_Label.Size = new System.Drawing.Size(36, 13);
            this.Phone_Number_Label.TabIndex = 2;
            this.Phone_Number_Label.Text = "Call :";
            // 
            // PhoneName_Label
            // 
            this.PhoneName_Label.AutoSize = true;
            this.PhoneName_Label.Location = new System.Drawing.Point(16, 36);
            this.PhoneName_Label.Name = "PhoneName_Label";
            this.PhoneName_Label.Size = new System.Drawing.Size(69, 13);
            this.PhoneName_Label.TabIndex = 3;
            this.PhoneName_Label.Text = "Phone Name";
            this.PhoneName_Label.Click += new System.EventHandler(this.PhoneName_Label_Click);
            // 
            // Quantity_Label
            // 
            this.Quantity_Label.AutoSize = true;
            this.Quantity_Label.Location = new System.Drawing.Point(45, 161);
            this.Quantity_Label.Name = "Quantity_Label";
            this.Quantity_Label.Size = new System.Drawing.Size(46, 13);
            this.Quantity_Label.TabIndex = 4;
            this.Quantity_Label.Text = "Quantity";
            // 
            // Customer_Panel
            // 
            this.Customer_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Customer_Panel.Controls.Add(this.label5);
            this.Customer_Panel.Controls.Add(this.dateTimePicker1);
            this.Customer_Panel.Controls.Add(this.pictureBox1);
            this.Customer_Panel.Controls.Add(this.Phone_Number_Textbox);
            this.Customer_Panel.Controls.Add(this.Address_Textbox);
            this.Customer_Panel.Controls.Add(this.Name_Textbox);
            this.Customer_Panel.Controls.Add(this.panel3);
            this.Customer_Panel.Controls.Add(this.panel1);
            this.Customer_Panel.Controls.Add(this.panel2);
            this.Customer_Panel.Controls.Add(this.Customer_Inf_Label);
            this.Customer_Panel.Controls.Add(this.Name_Label);
            this.Customer_Panel.Controls.Add(this.Address_Label);
            this.Customer_Panel.Controls.Add(this.Phone_Number_Label);
            this.Customer_Panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Customer_Panel.Location = new System.Drawing.Point(12, 12);
            this.Customer_Panel.Name = "Customer_Panel";
            this.Customer_Panel.Size = new System.Drawing.Size(353, 168);
            this.Customer_Panel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(30, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 137);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneManagerment_ADO.net.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Phone_Number_Textbox
            // 
            this.Phone_Number_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.Phone_Number_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phone_Number_Textbox.Location = new System.Drawing.Point(68, 115);
            this.Phone_Number_Textbox.Name = "Phone_Number_Textbox";
            this.Phone_Number_Textbox.Size = new System.Drawing.Size(270, 13);
            this.Phone_Number_Textbox.TabIndex = 10;
            // 
            // Address_Textbox
            // 
            this.Address_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.Address_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address_Textbox.Location = new System.Drawing.Point(68, 80);
            this.Address_Textbox.Name = "Address_Textbox";
            this.Address_Textbox.Size = new System.Drawing.Size(270, 13);
            this.Address_Textbox.TabIndex = 9;
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.Name_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_Textbox.Location = new System.Drawing.Point(68, 53);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(270, 13);
            this.Name_Textbox.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(68, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 1);
            this.panel3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(68, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(68, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 1);
            this.panel2.TabIndex = 6;
            // 
            // Customer_Inf_Label
            // 
            this.Customer_Inf_Label.AutoSize = true;
            this.Customer_Inf_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Inf_Label.ForeColor = System.Drawing.Color.Blue;
            this.Customer_Inf_Label.Location = new System.Drawing.Point(105, 4);
            this.Customer_Inf_Label.Name = "Customer_Inf_Label";
            this.Customer_Inf_Label.Size = new System.Drawing.Size(148, 16);
            this.Customer_Inf_Label.TabIndex = 3;
            this.Customer_Inf_Label.Text = "Customer Infomation";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txt_camera);
            this.panel4.Controls.Add(this.txt_sim);
            this.panel4.Controls.Add(this.txt_Price);
            this.panel4.Controls.Add(this.txt_Display);
            this.panel4.Controls.Add(this.txt_istorage);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txt_Ram);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbb_PhoneName);
            this.panel4.Controls.Add(this.Add_Phone_Button);
            this.panel4.Controls.Add(this.Phone_Inf_Label);
            this.panel4.Controls.Add(this.numeric_Quantity);
            this.panel4.Controls.Add(this.PhoneName_Label);
            this.panel4.Controls.Add(this.Quantity_Label);
            this.panel4.Location = new System.Drawing.Point(371, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(417, 187);
            this.panel4.TabIndex = 7;
            // 
            // txt_camera
            // 
            this.txt_camera.Location = new System.Drawing.Point(272, 97);
            this.txt_camera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_camera.Name = "txt_camera";
            this.txt_camera.Size = new System.Drawing.Size(86, 20);
            this.txt_camera.TabIndex = 12;
            // 
            // txt_sim
            // 
            this.txt_sim.Location = new System.Drawing.Point(272, 66);
            this.txt_sim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sim.Name = "txt_sim";
            this.txt_sim.Size = new System.Drawing.Size(86, 20);
            this.txt_sim.TabIndex = 12;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(272, 128);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(86, 20);
            this.txt_Price.TabIndex = 12;
            // 
            // txt_Display
            // 
            this.txt_Display.Location = new System.Drawing.Point(103, 130);
            this.txt_Display.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.Size = new System.Drawing.Size(86, 20);
            this.txt_Display.TabIndex = 12;
            // 
            // txt_istorage
            // 
            this.txt_istorage.Location = new System.Drawing.Point(103, 97);
            this.txt_istorage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_istorage.Name = "txt_istorage";
            this.txt_istorage.Size = new System.Drawing.Size(86, 20);
            this.txt_istorage.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "camera type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Price";
            // 
            // txt_Ram
            // 
            this.txt_Ram.Location = new System.Drawing.Point(103, 66);
            this.txt_Ram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Ram.Name = "txt_Ram";
            this.txt_Ram.Size = new System.Drawing.Size(86, 20);
            this.txt_Ram.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "display";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "sim type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "istorage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ram";
            // 
            // cbb_PhoneName
            // 
            this.cbb_PhoneName.FormattingEnabled = true;
            this.cbb_PhoneName.Location = new System.Drawing.Point(103, 33);
            this.cbb_PhoneName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_PhoneName.Name = "cbb_PhoneName";
            this.cbb_PhoneName.Size = new System.Drawing.Size(254, 21);
            this.cbb_PhoneName.TabIndex = 10;
            // 
            // Add_Phone_Button
            // 
            this.Add_Phone_Button.Location = new System.Drawing.Point(272, 152);
            this.Add_Phone_Button.Name = "Add_Phone_Button";
            this.Add_Phone_Button.Size = new System.Drawing.Size(85, 25);
            this.Add_Phone_Button.TabIndex = 9;
            this.Add_Phone_Button.Text = "Add";
            this.Add_Phone_Button.UseVisualStyleBackColor = true;
            this.Add_Phone_Button.Click += new System.EventHandler(this.Add_Phone_Button_Click);
            // 
            // Phone_Inf_Label
            // 
            this.Phone_Inf_Label.AutoSize = true;
            this.Phone_Inf_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Phone_Inf_Label.Location = new System.Drawing.Point(158, 7);
            this.Phone_Inf_Label.Name = "Phone_Inf_Label";
            this.Phone_Inf_Label.Size = new System.Drawing.Size(127, 16);
            this.Phone_Inf_Label.TabIndex = 8;
            this.Phone_Inf_Label.Text = "Phone Infomation";
            // 
            // numeric_Quantity
            // 
            this.numeric_Quantity.Location = new System.Drawing.Point(103, 159);
            this.numeric_Quantity.Name = "numeric_Quantity";
            this.numeric_Quantity.Size = new System.Drawing.Size(85, 20);
            this.numeric_Quantity.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phone_Column,
            this.Price_Column,
            this.Quantity_Column});
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(353, 229);
            this.dataGridView1.TabIndex = 8;
            // 
            // Total_Price_Label
            // 
            this.Total_Price_Label.AutoSize = true;
            this.Total_Price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price_Label.Location = new System.Drawing.Point(378, 299);
            this.Total_Price_Label.Name = "Total_Price_Label";
            this.Total_Price_Label.Size = new System.Drawing.Size(56, 24);
            this.Total_Price_Label.TabIndex = 9;
            this.Total_Price_Label.Text = "Total";
            // 
            // Total_Price_Textbox
            // 
            this.Total_Price_Textbox.Enabled = false;
            this.Total_Price_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price_Textbox.Location = new System.Drawing.Point(382, 334);
            this.Total_Price_Textbox.Name = "Total_Price_Textbox";
            this.Total_Price_Textbox.Size = new System.Drawing.Size(288, 27);
            this.Total_Price_Textbox.TabIndex = 10;
            // 
            // Export_Button
            // 
            this.Export_Button.Location = new System.Drawing.Point(577, 384);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(90, 42);
            this.Export_Button.TabIndex = 11;
            this.Export_Button.Text = "Export";
            this.Export_Button.UseVisualStyleBackColor = true;
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(371, 222);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 46);
            this.Remove_Button.TabIndex = 12;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(549, 222);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 46);
            this.Reset_Button.TabIndex = 13;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhoneManagerment_ADO.net.Properties.Resources.hand;
            this.pictureBox2.Location = new System.Drawing.Point(679, 315);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(709, 222);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 46);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Basket";
            // 
            // Phone_Column
            // 
            this.Phone_Column.HeaderText = "Phone";
            this.Phone_Column.MinimumWidth = 6;
            this.Phone_Column.Name = "Phone_Column";
            this.Phone_Column.ReadOnly = true;
            this.Phone_Column.Width = 175;
            // 
            // Price_Column
            // 
            this.Price_Column.HeaderText = "Price (vnđ)";
            this.Price_Column.MinimumWidth = 6;
            this.Price_Column.Name = "Price_Column";
            this.Price_Column.ReadOnly = true;
            this.Price_Column.Width = 125;
            // 
            // Quantity_Column
            // 
            this.Quantity_Column.HeaderText = "Quantity";
            this.Quantity_Column.MinimumWidth = 6;
            this.Quantity_Column.Name = "Quantity_Column";
            this.Quantity_Column.ReadOnly = true;
            this.Quantity_Column.Width = 50;
            // 
            // Form_AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Export_Button);
            this.Controls.Add(this.Total_Price_Textbox);
            this.Controls.Add(this.Total_Price_Label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Customer_Panel);
            this.Name = "Form_AddTransaction";
            this.Text = "Form_AddTransaction";
            this.Customer_Panel.ResumeLayout(false);
            this.Customer_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label Phone_Number_Label;
        private System.Windows.Forms.Label PhoneName_Label;
        private System.Windows.Forms.Label Quantity_Label;
        private System.Windows.Forms.Panel Customer_Panel;
        private System.Windows.Forms.Label Customer_Inf_Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Phone_Number_Textbox;
        private System.Windows.Forms.TextBox Address_Textbox;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numeric_Quantity;
        private System.Windows.Forms.Label Phone_Inf_Label;
        private System.Windows.Forms.Button Add_Phone_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Total_Price_Label;
        private System.Windows.Forms.TextBox Total_Price_Textbox;
        private System.Windows.Forms.Button Export_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_camera;
        private System.Windows.Forms.TextBox txt_sim;
        private System.Windows.Forms.TextBox txt_istorage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Ram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_PhoneName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Display;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Column;
    }
}