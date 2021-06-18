
namespace PhoneManagerment_ADO.net
{
    partial class Form_Shop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Phone_Inf_Label = new System.Windows.Forms.Label();
            this.PhoneName_Label = new System.Windows.Forms.Label();
            this.txt_PhoneName = new System.Windows.Forms.TextBox();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.btn_Choose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PhoneName_Label);
            this.panel1.Controls.Add(this.txt_PhoneName);
            this.panel1.Controls.Add(this.Phone_Inf_Label);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 76);
            this.panel1.TabIndex = 0;
            // 
            // Phone_Inf_Label
            // 
            this.Phone_Inf_Label.AutoSize = true;
            this.Phone_Inf_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Phone_Inf_Label.Location = new System.Drawing.Point(308, 10);
            this.Phone_Inf_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phone_Inf_Label.Name = "Phone_Inf_Label";
            this.Phone_Inf_Label.Size = new System.Drawing.Size(154, 20);
            this.Phone_Inf_Label.TabIndex = 9;
            this.Phone_Inf_Label.Text = "Phone Infomation";
            // 
            // PhoneName_Label
            // 
            this.PhoneName_Label.AutoSize = true;
            this.PhoneName_Label.Location = new System.Drawing.Point(121, 37);
            this.PhoneName_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneName_Label.Name = "PhoneName_Label";
            this.PhoneName_Label.Size = new System.Drawing.Size(90, 17);
            this.PhoneName_Label.TabIndex = 10;
            this.PhoneName_Label.Text = "Phone Name";
            // 
            // txt_PhoneName
            // 
            this.txt_PhoneName.Location = new System.Drawing.Point(226, 34);
            this.txt_PhoneName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PhoneName.Name = "txt_PhoneName";
            this.txt_PhoneName.Size = new System.Drawing.Size(340, 22);
            this.txt_PhoneName.TabIndex = 11;
            // 
            // dgvPhones
            // 
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.Location = new System.Drawing.Point(13, 96);
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.RowHeadersWidth = 51;
            this.dgvPhones.RowTemplate.Height = 24;
            this.dgvPhones.Size = new System.Drawing.Size(775, 258);
            this.dgvPhones.TabIndex = 1;
            // 
            // btn_Choose
            // 
            this.btn_Choose.Location = new System.Drawing.Point(325, 369);
            this.btn_Choose.Name = "btn_Choose";
            this.btn_Choose.Size = new System.Drawing.Size(150, 43);
            this.btn_Choose.TabIndex = 2;
            this.btn_Choose.Text = "Choose";
            this.btn_Choose.UseVisualStyleBackColor = true;
            // 
            // Form_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Choose);
            this.Controls.Add(this.dgvPhones);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Shop";
            this.Text = "Form_Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Phone_Inf_Label;
        private System.Windows.Forms.Label PhoneName_Label;
        private System.Windows.Forms.TextBox txt_PhoneName;
        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.Button btn_Choose;
    }
}