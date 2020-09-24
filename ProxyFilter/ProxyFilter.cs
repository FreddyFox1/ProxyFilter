using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyFilter
{
    public partial class ProxyFilter : Form
    {
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
                tbProxyFile.Text = FileName;
                lbProxy.ForeColor = Color.Green;
            }
            else
            {
                lbProxy.ForeColor = Color.Red;
                tbProxyFile.Text = "";
            }
        }

        private void butStartConversion_Click(object sender, EventArgs e)
        {

        }

        private void Conversion()
        {
            int k = 0;
            //for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                }
            }
        }

        private void SaveIntoFile()
        {

        }


    }
}
