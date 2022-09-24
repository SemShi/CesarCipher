using CesarCipher.Classes;
using System.Text;

namespace CesarCipher.Forms
{
    public partial class FreqAnalysis : Form
    {
        private char[] freqList = "оеаинтсрвлкмдпуяыьгзбчйхжшюцщэфъё".ToCharArray();
        private char[] alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        private char[] freqMsg;
        private int _shift;
        private Dictionary<char, int> freqMsgList = new Dictionary<char, int>();
        
        public FreqAnalysis()
        {
            InitializeComponent();
        }

        private void OnFreqStart(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_msg.Text)) return;
            tb_result.Text = "";
            FreqInMsg();
            FreqAnalisys();
            
        }

        private void FreqInMsg()
        {
            var res = tb_msg.Text.ToLower().GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            foreach (var item in res.OrderByDescending(x => x.Value))
            {
                freqMsgList.Add(item.Key, item.Value);
            }

            string str = "";
            foreach (var k in freqMsgList.Keys)
            {
                str += char.ConvertFromUtf32((int)k);
            }
            freqMsg = str.ToCharArray();
        }

        private void FreqAnalisys()
        {
            int msgLetter = -1;
            int ordLetter = -1;
            int j = 0;
            for(int i = 0; i < freqMsg.Length; i++)
            {
                
                //if (msgLetter >= 0 && ordLetter >= 0) break;
                for (; j < freqList.Length; j++)
                {
                    if (msgLetter >= 0 && ordLetter >= 0) {
                        msgLetter = -1;
                        ordLetter = -1;
                        break;
                    } 
                    for (int k = 0; k< alphabet.Length; k++)
                    {
                        if (freqMsg[i] == alphabet[k]) msgLetter = k; //буква у залетает в переменную
                        else if (freqList[j] == alphabet[k]) ordLetter = k; //буква о залетает в переменную
                        if (msgLetter >= 0 && ordLetter >= 0) 
                        {
                            _shift = Math.Abs(ordLetter - msgLetter) % 32;
                            tb_result.Text += $"Сдвиг={_shift}, расшифровка: " + Encrypter.OnDecrypt(tb_msg.Text, _shift) + ";" + Environment.NewLine;
                            break;
                        } 
                    }
                }
                
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
