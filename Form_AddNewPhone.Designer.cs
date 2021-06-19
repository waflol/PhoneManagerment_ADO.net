
namespace PhoneManagerment_ADO.net
{
    partial class Form_AddNewPhone
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
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cbb_NetworkType = new System.Windows.Forms.ComboBox();
            this.cbb_SimType = new System.Windows.Forms.ComboBox();
            this.cbb_FingerprintSensor = new System.Windows.Forms.ComboBox();
            this.cbb_FrontCamera = new System.Windows.Forms.ComboBox();
            this.cbb_RearCamera = new System.Windows.Forms.ComboBox();
            this.cbb_Display = new System.Windows.Forms.ComboBox();
            this.cbb_InternalStorage = new System.Windows.Forms.ComboBox();
            this.txt_ModelName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Ram = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(392, 380);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(133, 26);
            this.txt_Price.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(325, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 49;
            this.label12.Text = "Price";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(447, 423);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(78, 32);
            this.btn_Reset.TabIndex = 48;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(322, 423);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(78, 32);
            this.btn_Save.TabIndex = 47;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cbb_NetworkType
            // 
            this.cbb_NetworkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NetworkType.FormattingEnabled = true;
            this.cbb_NetworkType.Items.AddRange(new object[] {
            "2G",
            "2G, 3G",
            "2G, 3G & 4G VOLT",
            "5G"});
            this.cbb_NetworkType.Location = new System.Drawing.Point(631, 317);
            this.cbb_NetworkType.Name = "cbb_NetworkType";
            this.cbb_NetworkType.Size = new System.Drawing.Size(152, 28);
            this.cbb_NetworkType.TabIndex = 46;
            this.cbb_NetworkType.Text = "--Select--";
            // 
            // cbb_SimType
            // 
            this.cbb_SimType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_SimType.FormattingEnabled = true;
            this.cbb_SimType.Items.AddRange(new object[] {
            "One Sim",
            "Dual Sim",
            "Triple Sim"});
            this.cbb_SimType.Location = new System.Drawing.Point(628, 256);
            this.cbb_SimType.Name = "cbb_SimType";
            this.cbb_SimType.Size = new System.Drawing.Size(152, 28);
            this.cbb_SimType.TabIndex = 45;
            this.cbb_SimType.Text = "--Select--";
            // 
            // cbb_FingerprintSensor
            // 
            this.cbb_FingerprintSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_FingerprintSensor.FormattingEnabled = true;
            this.cbb_FingerprintSensor.Items.AddRange(new object[] {
            "Yes ",
            "No"});
            this.cbb_FingerprintSensor.Location = new System.Drawing.Point(628, 192);
            this.cbb_FingerprintSensor.Name = "cbb_FingerprintSensor";
            this.cbb_FingerprintSensor.Size = new System.Drawing.Size(152, 28);
            this.cbb_FingerprintSensor.TabIndex = 44;
            this.cbb_FingerprintSensor.Text = "--Select--";
            // 
            // cbb_FrontCamera
            // 
            this.cbb_FrontCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_FrontCamera.FormattingEnabled = true;
            this.cbb_FrontCamera.Items.AddRange(new object[] {
            "2 MP",
            "3 MP",
            "5 MP",
            "8 MP",
            "10 MP",
            "12 MP"});
            this.cbb_FrontCamera.Location = new System.Drawing.Point(628, 125);
            this.cbb_FrontCamera.Name = "cbb_FrontCamera";
            this.cbb_FrontCamera.Size = new System.Drawing.Size(152, 28);
            this.cbb_FrontCamera.TabIndex = 43;
            this.cbb_FrontCamera.Text = "--Select--";
            // 
            // cbb_RearCamera
            // 
            this.cbb_RearCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_RearCamera.FormattingEnabled = true;
            this.cbb_RearCamera.Items.AddRange(new object[] {
            "5 MP",
            "8 MP",
            "10 MP",
            "11 MP",
            "12 MP",
            "13 MP",
            "15 MP",
            "17 MP",
            "20 MP",
            "32 MP",
            "64 MP",
            "128 MP"});
            this.cbb_RearCamera.Location = new System.Drawing.Point(628, 54);
            this.cbb_RearCamera.Name = "cbb_RearCamera";
            this.cbb_RearCamera.Size = new System.Drawing.Size(152, 28);
            this.cbb_RearCamera.TabIndex = 42;
            this.cbb_RearCamera.Text = "--Select--";
            // 
            // cbb_Display
            // 
            this.cbb_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Display.FormattingEnabled = true;
            this.cbb_Display.Items.AddRange(new object[] {
            "4.9 inch",
            "5.0 inch",
            "5.5 inch",
            "6.0 inch",
            "6.3 inch",
            "7.0 inch"});
            this.cbb_Display.Location = new System.Drawing.Point(221, 263);
            this.cbb_Display.Name = "cbb_Display";
            this.cbb_Display.Size = new System.Drawing.Size(152, 28);
            this.cbb_Display.TabIndex = 41;
            this.cbb_Display.Text = "--Select--";
            // 
            // cbb_InternalStorage
            // 
            this.cbb_InternalStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_InternalStorage.FormattingEnabled = true;
            this.cbb_InternalStorage.Items.AddRange(new object[] {
            "4 GB",
            "8 GB",
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB",
            "256 GB",
            "512 GB",
            "1 TB"});
            this.cbb_InternalStorage.Location = new System.Drawing.Point(221, 192);
            this.cbb_InternalStorage.Name = "cbb_InternalStorage";
            this.cbb_InternalStorage.Size = new System.Drawing.Size(152, 28);
            this.cbb_InternalStorage.TabIndex = 39;
            this.cbb_InternalStorage.Text = "--Select--";
            // 
            // txt_ModelName
            // 
            this.txt_ModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModelName.Location = new System.Drawing.Point(221, 57);
            this.txt_ModelName.Name = "txt_ModelName";
            this.txt_ModelName.Size = new System.Drawing.Size(203, 26);
            this.txt_ModelName.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(480, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "Network Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(516, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "Sim Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(447, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 24);
            this.label9.TabIndex = 34;
            this.label9.Text = "Fingerprint sensor ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(487, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Front Camera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(495, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Rear Camera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(122, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Display";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(59, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Internal Storage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(140, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "RAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(84, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Model Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(256, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Insert New Phone Records";
            // 
            // cbb_Ram
            // 
            this.cbb_Ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Ram.FormattingEnabled = true;
            this.cbb_Ram.Items.AddRange(new object[] {
            "1 GB",
            "2 GB",
            "3 GB",
            "4 GB",
            "6 GB",
            "12 GB",
            "16 GB",
            "32 GB",
            "64 GB"});
            this.cbb_Ram.Location = new System.Drawing.Point(221, 125);
            this.cbb_Ram.Name = "cbb_Ram";
            this.cbb_Ram.Size = new System.Drawing.Size(152, 28);
            this.cbb_Ram.TabIndex = 38;
            this.cbb_Ram.Text = "--Select--";
            // 
            // Form_AddNewPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cbb_NetworkType);
            this.Controls.Add(this.cbb_SimType);
            this.Controls.Add(this.cbb_FingerprintSensor);
            this.Controls.Add(this.cbb_FrontCamera);
            this.Controls.Add(this.cbb_RearCamera);
            this.Controls.Add(this.cbb_Display);
            this.Controls.Add(this.cbb_InternalStorage);
            this.Controls.Add(this.cbb_Ram);
            this.Controls.Add(this.txt_ModelName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_AddNewPhone";
            this.Text = "Form_AddNewPhone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cbb_NetworkType;
        private System.Windows.Forms.ComboBox cbb_SimType;
        private System.Windows.Forms.ComboBox cbb_FingerprintSensor;
        private System.Windows.Forms.ComboBox cbb_FrontCamera;
        private System.Windows.Forms.ComboBox cbb_RearCamera;
        private System.Windows.Forms.ComboBox cbb_Display;
        private System.Windows.Forms.ComboBox cbb_InternalStorage;
        private System.Windows.Forms.TextBox txt_ModelName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Ram;
    }
}