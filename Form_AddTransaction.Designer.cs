
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
            this.Total_Price_Label = new System.Windows.Forms.Label();
            this.Total_Price_Textbox = new System.Windows.Forms.TextBox();
            this.Export_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_Quantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_watchPhone = new System.Windows.Forms.DataGridView();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.listCart = new System.Windows.Forms.ListView();
            this.Customer_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_watchPhone)).BeginInit();
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
            this.Customer_Panel.Size = new System.Drawing.Size(374, 168);
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
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
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
            // Total_Price_Label
            // 
            this.Total_Price_Label.AutoSize = true;
            this.Total_Price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price_Label.Location = new System.Drawing.Point(602, 308);
            this.Total_Price_Label.Name = "Total_Price_Label";
            this.Total_Price_Label.Size = new System.Drawing.Size(56, 24);
            this.Total_Price_Label.TabIndex = 9;
            this.Total_Price_Label.Text = "Total";
            this.Total_Price_Label.Click += new System.EventHandler(this.Total_Price_Label_Click);
            // 
            // Total_Price_Textbox
            // 
            this.Total_Price_Textbox.Enabled = false;
            this.Total_Price_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price_Textbox.Location = new System.Drawing.Point(464, 335);
            this.Total_Price_Textbox.Name = "Total_Price_Textbox";
            this.Total_Price_Textbox.Size = new System.Drawing.Size(206, 27);
            this.Total_Price_Textbox.TabIndex = 10;
            // 
            // Export_Button
            // 
            this.Export_Button.BackgroundImage = global::PhoneManagerment_ADO.net.Properties.Resources.hand;
            this.Export_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Export_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_Button.Location = new System.Drawing.Point(676, 308);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(118, 111);
            this.Export_Button.TabIndex = 11;
            this.Export_Button.Text = "Export - Deal";
            this.Export_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Export_Button.UseVisualStyleBackColor = true;
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(504, 247);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 46);
            this.Remove_Button.TabIndex = 12;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(606, 247);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 46);
            this.Reset_Button.TabIndex = 13;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(707, 247);
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
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cart";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(392, 245);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 46);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(429, 186);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(100, 20);
            this.txt_Phone.TabIndex = 18;
            this.txt_Phone.TextChanged += new System.EventHandler(this.txt_Phone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phone";
            // 
            // numeric_Quantity
            // 
            this.numeric_Quantity.Location = new System.Drawing.Point(719, 186);
            this.numeric_Quantity.Name = "numeric_Quantity";
            this.numeric_Quantity.Size = new System.Drawing.Size(53, 20);
            this.numeric_Quantity.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantity";
            // 
            // dgv_watchPhone
            // 
            this.dgv_watchPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_watchPhone.Location = new System.Drawing.Point(392, 12);
            this.dgv_watchPhone.Name = "dgv_watchPhone";
            this.dgv_watchPhone.Size = new System.Drawing.Size(390, 168);
            this.dgv_watchPhone.TabIndex = 22;
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(574, 373);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(75, 46);
            this.btn_Pay.TabIndex = 12;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // listCart
            // 
            this.listCart.HideSelection = false;
            this.listCart.Location = new System.Drawing.Point(12, 203);
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(374, 235);
            this.listCart.TabIndex = 23;
            this.listCart.UseCompatibleStateImageBehavior = false;
            // 
            // Form_AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.listCart);
            this.Controls.Add(this.dgv_watchPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_Quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Export_Button);
            this.Controls.Add(this.Total_Price_Textbox);
            this.Controls.Add(this.Total_Price_Label);
            this.Controls.Add(this.Customer_Panel);
            this.Name = "Form_AddTransaction";
            this.Text = "Form_AddTransaction";
            this.Load += new System.EventHandler(this.Form_AddTransaction_Load);
            this.Customer_Panel.ResumeLayout(false);
            this.Customer_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_watchPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label Phone_Number_Label;
        private System.Windows.Forms.Panel Customer_Panel;
        private System.Windows.Forms.Label Customer_Inf_Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Phone_Number_Textbox;
        private System.Windows.Forms.TextBox Address_Textbox;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Total_Price_Label;
        private System.Windows.Forms.TextBox Total_Price_Textbox;
        private System.Windows.Forms.Button Export_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_watchPhone;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.ListView listCart;
    }
}