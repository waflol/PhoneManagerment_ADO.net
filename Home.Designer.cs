
namespace PhoneManagerment_ADO.net
{
    partial class Home
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
            this.menu_Home = new System.Windows.Forms.MenuStrip();
            this.addTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wareHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vHGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lNHAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Home
            // 
            this.menu_Home.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem,
            this.transactionDetailToolStripMenuItem,
            this.addNewPhoneToolStripMenuItem,
            this.phoneDetailsToolStripMenuItem,
            this.wareHouseToolStripMenuItem,
            this.infomationToolStripMenuItem});
            this.menu_Home.Location = new System.Drawing.Point(0, 0);
            this.menu_Home.Name = "menu_Home";
            this.menu_Home.Size = new System.Drawing.Size(981, 33);
            this.menu_Home.TabIndex = 0;
            this.menu_Home.Text = "menuStrip1";
            // 
            // addTransactionToolStripMenuItem
            // 
            this.addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            this.addTransactionToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.addTransactionToolStripMenuItem.Text = "Add transaction";
            this.addTransactionToolStripMenuItem.Click += new System.EventHandler(this.addTransactionToolStripMenuItem_Click);
            // 
            // transactionDetailToolStripMenuItem
            // 
            this.transactionDetailToolStripMenuItem.Name = "transactionDetailToolStripMenuItem";
            this.transactionDetailToolStripMenuItem.Size = new System.Drawing.Size(189, 29);
            this.transactionDetailToolStripMenuItem.Text = "Transaction details";
            // 
            // addNewPhoneToolStripMenuItem
            // 
            this.addNewPhoneToolStripMenuItem.Name = "addNewPhoneToolStripMenuItem";
            this.addNewPhoneToolStripMenuItem.Size = new System.Drawing.Size(165, 29);
            this.addNewPhoneToolStripMenuItem.Text = "Add new phone";
            // 
            // phoneDetailsToolStripMenuItem
            // 
            this.phoneDetailsToolStripMenuItem.Name = "phoneDetailsToolStripMenuItem";
            this.phoneDetailsToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.phoneDetailsToolStripMenuItem.Text = "Phone details";
            // 
            // wareHouseToolStripMenuItem
            // 
            this.wareHouseToolStripMenuItem.Name = "wareHouseToolStripMenuItem";
            this.wareHouseToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.wareHouseToolStripMenuItem.Text = "WareHouse";
            // 
            // infomationToolStripMenuItem
            // 
            this.infomationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vHGToolStripMenuItem,
            this.hTHToolStripMenuItem,
            this.lNHAToolStripMenuItem});
            this.infomationToolStripMenuItem.Name = "infomationToolStripMenuItem";
            this.infomationToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.infomationToolStripMenuItem.Text = "Infomation";
            // 
            // vHGToolStripMenuItem
            // 
            this.vHGToolStripMenuItem.Name = "vHGToolStripMenuItem";
            this.vHGToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.vHGToolStripMenuItem.Text = "VHG";
            // 
            // hTHToolStripMenuItem
            // 
            this.hTHToolStripMenuItem.Name = "hTHToolStripMenuItem";
            this.hTHToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.hTHToolStripMenuItem.Text = "HTH";
            // 
            // lNHAToolStripMenuItem
            // 
            this.lNHAToolStripMenuItem.Name = "lNHAToolStripMenuItem";
            this.lNHAToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.lNHAToolStripMenuItem.Text = "LNHA";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 514);
            this.Controls.Add(this.menu_Home);
            this.MainMenuStrip = this.menu_Home;
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.menu_Home.ResumeLayout(false);
            this.menu_Home.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Home;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wareHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vHGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lNHAToolStripMenuItem;
    }
}