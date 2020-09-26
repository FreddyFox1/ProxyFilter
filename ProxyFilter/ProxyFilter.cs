using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProxyFilter
{
    public partial class ProxyFilter : Form
    {
        FileEditor fileEditor = new FileEditor();
        public ProxyFilter()
        {
            InitializeComponent();
        }

        private void butProxyFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog()
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (opf.ShowDialog() == DialogResult.OK)
            {
                string FileName = opf.FileName;
                string TextFile = System.IO.File.ReadAllText(FileName);
                tbProxyFile.Text = FileName;
                lbProxy.ForeColor = Color.Green;
                fileEditor.ProxyFile = fileEditor.ReadFile(FileName);
                lbProxyCount.Text = "Proxy: " + fileEditor.ProxyFile.Length.ToString();
            }
            else
            {
                lbProxy.ForeColor = Color.Red;
                tbProxyFile.Text = "";
            }
        }

        private void butAccountsFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog()
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (opf.ShowDialog() == DialogResult.OK)
            {
                string FileName = opf.FileName;
                string TextFile = System.IO.File.ReadAllText(FileName);
                tbAccountsFile.Text = FileName;
                lbAccounts.ForeColor = Color.Green;
                fileEditor.AccountsFile = fileEditor.ReadFile(FileName);
                lbAccCount.Text = "Accounts: " + fileEditor.AccountsFile.Length.ToString();
            }
            else
            {
                lbAccounts.ForeColor = Color.Red;
                tbAccountsFile.Text = "";
            }
        }

        private void butStartConversion_Click(object sender, EventArgs e)
        {
            fileEditor.Conversion();
        }





    }
}
