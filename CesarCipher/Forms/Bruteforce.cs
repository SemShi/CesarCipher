using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CesarCipher.Classes;

namespace CesarCipher.Forms
{
    public partial class Bruteforce : Form
    {
        public Bruteforce()
        {
            InitializeComponent();
        }

        private void OnBruteStart(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_msg.Text)) return;
            tb_result.Text = "";
            for(int i = 1; i <= 31; i++)
            {
                tb_result.Text += $"Сдвиг={i}, расшифровка: " + Encrypter.OnDecrypt(tb_msg.Text, i) + ";" + Environment.NewLine;
            }
        }

        #region Сохранение и загрузка из файла
        private void OnOpenFile(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Files | *.txt";
            file.ShowDialog();
            string path = file.FileName;
            if (string.IsNullOrWhiteSpace(path)) return;
            StreamReader sr = new StreamReader(path);
            tb_msg.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void OnSaveFile(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Text Files | *.txt";
            file.ShowDialog();
            string path = file.FileName;
            if (string.IsNullOrWhiteSpace(path)) return;
            StreamWriter sr = new StreamWriter(path);
            sr.Write(tb_result.Text, Encoding.UTF8);
            sr.Close();
        }
        #endregion
    }
}
