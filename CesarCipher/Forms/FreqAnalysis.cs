using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CesarCipher.Forms
{
    public partial class FreqAnalysis : Form
    {
        private char[] freqList = "оеаинтсрвлкмдпуяыьгзбчйхжшюцщэфъё".ToCharArray();
        public FreqAnalysis()
        {
            InitializeComponent();
        }

        private void OnFreqStart(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_msg.Text)) return;
            tb_result.Text = "";

        }

        private void FreqInMsg()
        {
            for(int i = 0; i < freqList.Length; i++)
            {
                int letter = (char)freqList[i];
                int tmp = 0;
                int count1 = 0;
                int count2 = 0;
                for (int j = 0; j < freqList.Length; j++)
                {
                    if (letter == freqList[j]) count1++; count2 = count1;
                }
                //zakonchil zdes
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
