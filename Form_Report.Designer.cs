
namespace PhoneManagerment_ADO.net {
    partial class Form_Report {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhoneDB = new PhoneManagerment_ADO.net.PhoneDB();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Show_Button = new System.Windows.Forms.Button();
            this.TransactionsTableAdapter = new PhoneManagerment_ADO.net.PhoneDBTableAdapters.TransactionsTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneDB)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionsBindingSource
            // 
            this.TransactionsBindingSource.DataMember = "Transactions";
            this.TransactionsBindingSource.DataSource = this.PhoneDB;
            // 
            // PhoneDB
            // 
            this.PhoneDB.DataSetName = "PhoneDB";
            this.PhoneDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Dataset_PhoneDB";
            reportDataSource1.Value = this.TransactionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhoneManagerment_ADO.net.Report_TongTienBanDt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(343, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Show_Button
            // 
            this.Show_Button.Location = new System.Drawing.Point(262, 45);
            this.Show_Button.Name = "Show_Button";
            this.Show_Button.Size = new System.Drawing.Size(75, 23);
            this.Show_Button.TabIndex = 2;
            this.Show_Button.Text = "Show";
            this.Show_Button.UseVisualStyleBackColor = true;
            this.Show_Button.Click += new System.EventHandler(this.Show_Button_Click);
            // 
            // TransactionsTableAdapter
            // 
            this.TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn ngày";
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Show_Button);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Report";
            this.Load += new System.EventHandler(this.Form_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TransactionsBindingSource;
        private PhoneDB PhoneDB;
        private PhoneDBTableAdapters.TransactionsTableAdapter TransactionsTableAdapter;
        private System.Windows.Forms.Button Show_Button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}