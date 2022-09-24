using CesarCipher.Classes;
using System.Text;

namespace CesarCipher.Forms
{
    public partial class FreqAnalysis : Form
    {
        private char[] freqList = "оеаинтсрвлкмдпуяыьгзбчйхжшюцщэфъ".ToCharArray();
        private char[] alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        private char[] freqMsg;
        private int _shift;
        private bool repeat_ignore = false;
        private bool change_direction = false;
        private Dictionary<char, int> freqMsgList = new Dictionary<char, int>();
        private Dictionary<char, decimal> freqMsgLetters = new Dictionary<char, decimal>();
        public FreqAnalysis()
        {
            InitializeComponent();
        }

        private void OnFreqStart(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_msg.Text)) return;
            freqMsgList.Clear();
            freqMsgLetters.Clear();
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

            foreach (var item in freqMsgList)
            {
                if (!char.IsLetter(item.Key)) continue;
                freqMsgLetters.Add(item.Key, Math.Round(((decimal)item.Value / (decimal)tb_msg.Text.Length),5));
            }

            string mostUsedLetter = "";
            foreach (var item in freqMsgLetters.Keys)
            {
                mostUsedLetter += item.ToString();
            }
            freqMsg = mostUsedLetter.ToCharArray();
        }

        private void FreqAnalisys()
        {
            if (!repeat_ignore)
            {
                int letterFromMsg = -1;
                int letterFromFreqAlph = -1;
                for(int i = 0; i < freqMsg.Length; i++)
                {
                    if (letterFromMsg >= 0 && letterFromFreqAlph >= 0) break;
                    for (int j = 0; j < freqList.Length; j++)
                    {
                        if (letterFromMsg >= 0 && letterFromFreqAlph >= 0) break;
                        for (int k = 0; k< alphabet.Length; k++)
                        {
                            if (freqMsg[i] == alphabet[k]) letterFromMsg = k;
                            else if (freqList[j] == alphabet[k]) letterFromFreqAlph = k;
                            if (letterFromMsg >= 0 && letterFromFreqAlph >= 0) 
                            {
                                //repeat_ignore = true;
                                bt_changeDirection.Enabled = true;
                                if(change_direction) _shift = (32 - Math.Abs(letterFromMsg - letterFromFreqAlph)) % 32;
                                else _shift = Math.Abs(letterFromMsg - letterFromFreqAlph) % 32;
                                tb_result.Text = Encrypter.OnDecrypt(tb_msg.Text, _shift);
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                _shift++;
                tb_result.Text = Encrypter.OnDecrypt(tb_msg.Text, _shift);
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

        private void tb_changeDirection_Click(object sender, EventArgs e)
        {
            change_direction = true;
            bt_changeDirection.Enabled = false;
        }
    }
}
