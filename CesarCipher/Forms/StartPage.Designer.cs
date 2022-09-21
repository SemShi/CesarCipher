namespace CesarCipher
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_freqAnalysis = new System.Windows.Forms.Button();
            this.bt_bruteforceMode = new System.Windows.Forms.Button();
            this.bt_defaultMode = new System.Windows.Forms.Button();
            this.tb_btInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb_btInfo);
            this.splitContainer1.Size = new System.Drawing.Size(704, 311);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bt_freqAnalysis, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_bruteforceMode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_defaultMode, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bt_freqAnalysis
            // 
            this.bt_freqAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_freqAnalysis.Location = new System.Drawing.Point(3, 209);
            this.bt_freqAnalysis.Name = "bt_freqAnalysis";
            this.bt_freqAnalysis.Size = new System.Drawing.Size(258, 99);
            this.bt_freqAnalysis.TabIndex = 2;
            this.bt_freqAnalysis.Text = "Частотный анализ шифра";
            this.bt_freqAnalysis.UseVisualStyleBackColor = true;
            this.bt_freqAnalysis.Click += new System.EventHandler(this.LoadFreqAnalysisPage);
            this.bt_freqAnalysis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowButtonInfo);
            // 
            // bt_bruteforceMode
            // 
            this.bt_bruteforceMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_bruteforceMode.Location = new System.Drawing.Point(3, 106);
            this.bt_bruteforceMode.Name = "bt_bruteforceMode";
            this.bt_bruteforceMode.Size = new System.Drawing.Size(258, 97);
            this.bt_bruteforceMode.TabIndex = 1;
            this.bt_bruteforceMode.Text = "Метод перебора шифра";
            this.bt_bruteforceMode.UseVisualStyleBackColor = true;
            this.bt_bruteforceMode.Click += new System.EventHandler(this.LoadBruteforcePage);
            this.bt_bruteforceMode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowButtonInfo);
            // 
            // bt_defaultMode
            // 
            this.bt_defaultMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_defaultMode.Location = new System.Drawing.Point(3, 3);
            this.bt_defaultMode.Name = "bt_defaultMode";
            this.bt_defaultMode.Size = new System.Drawing.Size(258, 97);
            this.bt_defaultMode.TabIndex = 0;
            this.bt_defaultMode.Text = "Режим шифрования и расшифрования";
            this.bt_defaultMode.UseVisualStyleBackColor = true;
            this.bt_defaultMode.Click += new System.EventHandler(this.LoadDefaultModePage);
            this.bt_defaultMode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowButtonInfo);
            // 
            // tb_btInfo
            // 
            this.tb_btInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_btInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_btInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_btInfo.Location = new System.Drawing.Point(0, 0);
            this.tb_btInfo.Multiline = true;
            this.tb_btInfo.Name = "tb_btInfo";
            this.tb_btInfo.ReadOnly = true;
            this.tb_btInfo.Size = new System.Drawing.Size(436, 311);
            this.tb_btInfo.TabIndex = 0;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 311);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StartPage";
            this.Text = "CesarBuild";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button bt_freqAnalysis;
        private Button bt_bruteforceMode;
        private Button bt_defaultMode;
        private TextBox tb_btInfo;
    }
}