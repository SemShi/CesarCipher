namespace CesarCipher.Forms
{
    partial class FreqAnalysis
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
            this.bt_changeDirection = new System.Windows.Forms.Button();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.bt_EncryptMsg = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
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
            this.splitContainer1.Size = new System.Drawing.Size(805, 379);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bt_changeDirection, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_msg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_EncryptMsg, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bt_changeDirection
            // 
            this.bt_changeDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_changeDirection.Enabled = false;
            this.bt_changeDirection.Location = new System.Drawing.Point(3, 288);
            this.bt_changeDirection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_changeDirection.Name = "bt_changeDirection";
            this.bt_changeDirection.Size = new System.Drawing.Size(295, 87);
            this.bt_changeDirection.TabIndex = 3;
            this.bt_changeDirection.Text = "Изменить направление сдвига";
            this.bt_changeDirection.Click += new System.EventHandler(this.tb_changeDirection_Click);
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
            this.tb_msg.PlaceholderText = "сообщение";
            this.tb_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_msg.Size = new System.Drawing.Size(295, 134);
            this.tb_msg.TabIndex = 1;
            // 
            // bt_EncryptMsg
            // 
            this.bt_EncryptMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_EncryptMsg.Location = new System.Drawing.Point(3, 146);
            this.bt_EncryptMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_EncryptMsg.Name = "bt_EncryptMsg";
            this.bt_EncryptMsg.Size = new System.Drawing.Size(295, 134);
            this.bt_EncryptMsg.TabIndex = 2;
            this.bt_EncryptMsg.Text = "Расшифровать!";
            this.bt_EncryptMsg.Click += new System.EventHandler(this.OnFreqStart);
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
            this.tb_result.Size = new System.Drawing.Size(499, 379);
            this.tb_result.TabIndex = 0;
            // 
            // menuStrip1
            // 
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
            this.openFromFileToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.openFromFileToolStripMenuItem.Text = "Open file";
            this.openFromFileToolStripMenuItem.Click += new System.EventHandler(this.OnOpenFile);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.saveToFileToolStripMenuItem.Text = "Save file";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.OnSaveFile);
            // 
            // FreqAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 415);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FreqAnalysis";
            this.Text = "Метод частотного анализа";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox tb_result;
        private Button tb_changeDirection;
        private Button bt_changeDirection;
    }
}