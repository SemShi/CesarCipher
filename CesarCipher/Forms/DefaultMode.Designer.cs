namespace CesarCipher.Forms
{
    partial class DefaultMode
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.bt_EncryptMsg = new System.Windows.Forms.Button();
            this.bt_DecryptMsg = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb_result);
            this.splitContainer1.Size = new System.Drawing.Size(805, 381);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tb_msg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_EncryptMsg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_DecryptMsg, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_msg
            // 
            this.tb_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_msg.Location = new System.Drawing.Point(3, 4);
            this.tb_msg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_msg.Multiline = true;
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.PlaceholderText = "сообщение/сдвиг";
            this.tb_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_msg.Size = new System.Drawing.Size(295, 182);
            this.tb_msg.TabIndex = 1;
            // 
            // bt_EncryptMsg
            // 
            this.bt_EncryptMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_EncryptMsg.Location = new System.Drawing.Point(3, 194);
            this.bt_EncryptMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_EncryptMsg.Name = "bt_EncryptMsg";
            this.bt_EncryptMsg.Size = new System.Drawing.Size(295, 87);
            this.bt_EncryptMsg.TabIndex = 2;
            this.bt_EncryptMsg.Text = "Зашифровать сообщение";
            this.bt_EncryptMsg.UseVisualStyleBackColor = true;
            this.bt_EncryptMsg.Click += new System.EventHandler(this.OnStart);
            // 
            // bt_DecryptMsg
            // 
            this.bt_DecryptMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_DecryptMsg.Location = new System.Drawing.Point(3, 289);
            this.bt_DecryptMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_DecryptMsg.Name = "bt_DecryptMsg";
            this.bt_DecryptMsg.Size = new System.Drawing.Size(295, 88);
            this.bt_DecryptMsg.TabIndex = 3;
            this.bt_DecryptMsg.Text = "Расшифровать сообщение";
            this.bt_DecryptMsg.UseVisualStyleBackColor = true;
            this.bt_DecryptMsg.Click += new System.EventHandler(this.OnStart);
            // 
            // tb_result
            // 
            this.tb_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_result.Location = new System.Drawing.Point(0, 0);
            this.tb_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_result.Size = new System.Drawing.Size(499, 381);
            this.tb_result.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(805, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFromFileToolStripMenuItem
            // 
            this.openFromFileToolStripMenuItem.Name = "openFromFileToolStripMenuItem";
            this.openFromFileToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.openFromFileToolStripMenuItem.Text = "Open from file";
            this.openFromFileToolStripMenuItem.Click += new System.EventHandler(this.OnOpenFile);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.saveToFileToolStripMenuItem.Text = "Save to file";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.OnSaveFile);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(805, 415);
            this.splitContainer2.SplitterDistance = 30;
            this.splitContainer2.TabIndex = 2;
            // 
            // DefaultMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 415);
            this.Controls.Add(this.splitContainer2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DefaultMode";
            this.Text = "Режим шифрования и расшифрования";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFromFileToolStripMenuItem;
        private ToolStripMenuItem saveToFileToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tb_msg;
        private Button bt_EncryptMsg;
        private Button bt_DecryptMsg;
        private TextBox tb_result;
        private SplitContainer splitContainer2;
    }
}