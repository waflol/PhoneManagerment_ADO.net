﻿
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
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.phoneDBDataSet = new PhoneManagerment_ADO.net.PhoneDBDataSet();
            this.phoneDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneDB_Transaction_Details = new PhoneManagerment_ADO.net.PhoneDB_Transaction_Details();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new PhoneManagerment_ADO.net.PhoneDB_Transaction_DetailsTableAdapters.TransactionsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Details_Trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDB_Transaction_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
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
            this.GridView_Details_Trans.Size = new System.Drawing.Size(722, 297);
            this.GridView_Details_Trans.TabIndex = 0;
            this.GridView_Details_Trans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Details_Trans_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find Phone Number";
            // 
            // txt_IDTrans
            // 
            this.txt_IDTrans.Location = new System.Drawing.Point(246, 49);
            this.txt_IDTrans.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDTrans.Name = "txt_IDTrans";
            this.txt_IDTrans.Size = new System.Drawing.Size(162, 20);
            this.txt_IDTrans.TabIndex = 3;
            this.txt_IDTrans.TextChanged += new System.EventHandler(this.txt_IDTrans_TextChanged);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(57, 382);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 46);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(238, 382);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 46);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(404, 379);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(100, 46);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Form_TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.txt_IDTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView_Details_Trans);
            this.Name = "Form_TransactionDetails";
            this.Text = "Form_TransactionDetails";
            this.Load += new System.EventHandler(this.Form_TransactionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Details_Trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDB_Transaction_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_Details_Trans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDTrans;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.BindingSource phoneDBDataSetBindingSource;
        private PhoneDBDataSet phoneDBDataSet;
        private PhoneDB_Transaction_Details phoneDB_Transaction_Details;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private PhoneDB_Transaction_DetailsTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}