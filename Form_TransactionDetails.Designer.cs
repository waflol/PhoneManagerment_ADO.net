
namespace PhoneManagerment_ADO.net
{
    partial class Form_TransactionDetails
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
            this.components = new System.ComponentModel.Container();
            this.GridView_Details_Trans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDTrans = new System.Windows.Forms.TextBox();
            this.phoneDBDataSet = new PhoneManagerment_ADO.net.PhoneDBDataSet();
            this.phoneDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneDB_Transaction_Details = new PhoneManagerment_ADO.net.PhoneDB_Transaction_Details();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new PhoneManagerment_ADO.net.PhoneDB_Transaction_DetailsTableAdapters.TransactionsTableAdapter();
            this.btn_remove = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Details_Trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDB_Transaction_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_Details_Trans
            // 
            this.GridView_Details_Trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Details_Trans.Location = new System.Drawing.Point(9, 80);
            this.GridView_Details_Trans.Margin = new System.Windows.Forms.Padding(2);
            this.GridView_Details_Trans.Name = "GridView_Details_Trans";
            this.GridView_Details_Trans.RowHeadersWidth = 51;
            this.GridView_Details_Trans.RowTemplate.Height = 24;
            this.GridView_Details_Trans.Size = new System.Drawing.Size(769, 297);
            this.GridView_Details_Trans.TabIndex = 0;
            this.GridView_Details_Trans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Details_Trans_CellClick);
            this.GridView_Details_Trans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Details_Trans_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find Phone Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_IDTrans
            // 
            this.txt_IDTrans.Location = new System.Drawing.Point(290, 49);
            this.txt_IDTrans.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDTrans.Name = "txt_IDTrans";
            this.txt_IDTrans.Size = new System.Drawing.Size(162, 20);
            this.txt_IDTrans.TabIndex = 3;
            this.txt_IDTrans.TextChanged += new System.EventHandler(this.txt_IDTrans_TextChanged);
            // 
            // phoneDBDataSet
            // 
            this.phoneDBDataSet.DataSetName = "PhoneDBDataSet";
            this.phoneDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneDBDataSetBindingSource
            // 
            this.phoneDBDataSetBindingSource.DataSource = this.phoneDBDataSet;
            this.phoneDBDataSetBindingSource.Position = 0;
            // 
            // phoneDB_Transaction_Details
            // 
            this.phoneDB_Transaction_Details.DataSetName = "PhoneDB_Transaction_Details";
            this.phoneDB_Transaction_Details.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.phoneDB_Transaction_Details;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_remove
            // 
            this.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_remove.Location = new System.Drawing.Point(473, 48);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(61, 27);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhoneManagerment_ADO.net.Properties.Resources.earn_money_png_4;
            this.pictureBox2.Location = new System.Drawing.Point(28, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneManagerment_ADO.net.Properties.Resources.transaction;
            this.pictureBox1.Location = new System.Drawing.Point(691, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form_TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 387);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.txt_IDTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView_Details_Trans);
            this.Name = "Form_TransactionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_TransactionDetails";
            this.Load += new System.EventHandler(this.Form_TransactionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Details_Trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDB_Transaction_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_Details_Trans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDTrans;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.BindingSource phoneDBDataSetBindingSource;
        private PhoneDBDataSet phoneDBDataSet;
        private PhoneDB_Transaction_Details phoneDB_Transaction_Details;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private PhoneDB_Transaction_DetailsTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}