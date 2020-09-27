using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyFilter
{
    public class FileEditor
    {
        public string[] ProxyFile = new string[] { };
        public string[] AccountsFile = new string[] { };
        public static List<string> ResultData = new List<string>();

        public string[] ReadFile(string Path)
        {
            var result = File.ReadAllLines(Path);
            return result;
        }

        public void Conversion()
        {
            int k = 0, cIndex = 0;
            for (int i = 0; i < ProxyFile.Length; i++)
            {
                k = 0;
                if (cIndex != AccountsFile.Length)
                    for (int j = cIndex; j < AccountsFile.Length; j++)
                    {
                        if (k < 3)
                        {
                            ResultData.Add((AccountsFile[cIndex] + ":" + ProxyFile[i]).ToString());
                            cIndex++;
                            k++;
                        }
                        else break;
                    }
                else
                {
                    break;
                }
            }
            SaveIntoFile(ResultData);
        }
        private void SaveIntoFile(List<string> Data)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.AppendAllLines(sfd.FileName, Data);
                MessageBox.Show("Finish");
                Process.Start(sfd.FileName);

            }
        }
    }
}
