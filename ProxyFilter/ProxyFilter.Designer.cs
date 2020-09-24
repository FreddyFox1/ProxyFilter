namespace ProxyFilter
{
    partial class ProxyFilter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butProxyFile = new System.Windows.Forms.Button();
            this.butAccountsFile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbProxy = new System.Windows.Forms.Label();
            this.lbAccounts = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAccountsFile = new System.Windows.Forms.TextBox();
            this.tbProxyFile = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butProxyFile
            // 
            this.butProxyFile.Location = new System.Drawing.Point(94, 24);
            this.butProxyFile.Name = "butProxyFile";
            this.butProxyFile.Size = new System.Drawing.Size(75, 23);
            this.butProxyFile.TabIndex = 0;
            this.butProxyFile.Text = "Open";
            this.butProxyFile.UseVisualStyleBackColor = true;
            this.butProxyFile.Click += new System.EventHandler(this.butProxyFile_Click);
            // 
            // butAccountsFile
            // 
            this.butAccountsFile.Location = new System.Drawing.Point(94, 54);
            this.butAccountsFile.Name = "butAccountsFile";
            this.butAccountsFile.Size = new System.Drawing.Size(75, 23);
            this.butAccountsFile.TabIndex = 1;
            this.butAccountsFile.Text = "Open";
            this.butAccountsFile.UseVisualStyleBackColor = true;
            this.butAccountsFile.Click += new System.EventHandler(this.butAccountsFile_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.butStartConversion_Click);
            // 
            // lbProxy
            // 
            this.lbProxy.AutoSize = true;
            this.lbProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbProxy.Location = new System.Drawing.Point(32, 26);
            this.lbProxy.Name = "lbProxy";
            this.lbProxy.Size = new System.Drawing.Size(47, 17);
            this.lbProxy.TabIndex = 3;
            this.lbProxy.Text = "Proxy:";
            // 
            // lbAccounts
            // 
            this.lbAccounts.AutoSize = true;
            this.lbAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbAccounts.Location = new System.Drawing.Point(9, 54);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(70, 17);
            this.lbAccounts.TabIndex = 4;
            this.lbAccounts.Text = "Accounts:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAccountsFile);
            this.groupBox1.Controls.Add(this.tbProxyFile);
            this.groupBox1.Controls.Add(this.lbAccounts);
            this.groupBox1.Controls.Add(this.lbProxy);
            this.groupBox1.Controls.Add(this.butAccountsFile);
            this.groupBox1.Controls.Add(this.butProxyFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // tbAccountsFile
            // 
            this.tbAccountsFile.Enabled = false;
            this.tbAccountsFile.Location = new System.Drawing.Point(186, 56);
            this.tbAccountsFile.Name = "tbAccountsFile";
            this.tbAccountsFile.Size = new System.Drawing.Size(227, 20);
            this.tbAccountsFile.TabIndex = 6;
            // 
            // tbProxyFile
            // 
            this.tbProxyFile.Enabled = false;
            this.tbProxyFile.Location = new System.Drawing.Point(185, 26);
            this.tbProxyFile.Name = "tbProxyFile";
            this.tbProxyFile.Size = new System.Drawing.Size(227, 20);
            this.tbProxyFile.TabIndex = 5;
            // 
            // ProxyFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 143);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Name = "ProxyFilter";
            this.Text = "Proxy Filter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butProxyFile;
        private System.Windows.Forms.Button butAccountsFile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbProxy;
        private System.Windows.Forms.Label lbAccounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAccountsFile;
        private System.Windows.Forms.TextBox tbProxyFile;
    }
}

