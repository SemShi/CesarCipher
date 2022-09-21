using System.Text;

namespace CesarCipher.Forms
{
    public partial class DefaultMode : Form
    {
        #region Поля
        private static char[] _alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        private string _msg = "";
        private string _encryptedMsg = "";
        private string _decryptedMsg = "";
        private int _shift = 0;
        private int _encryption = 0;
        private int _decryption = 0;
        #endregion

        #region Конструкторы
        public DefaultMode()
        {
            InitializeComponent();
        }
        #endregion

        #region Основаня логика класса

        private void OnStart(object sender, EventArgs e)
        {
            if (!MsgSeparate()) return;
            if (((Button)sender).Name == "bt_EncryptMsg")
            {
                _encryptedMsg = "";
                tb_result.Text = "";
                tb_result.Text = "Зашифрованное сообщение: " + OnEncrypt();
            }
            else if (((Button)sender).Name == "bt_DecryptMsg")
            {
                _decryptedMsg = "";
                tb_result.Text = "";
                tb_result.Text = "Расшифрованное сообщение: " + OnDecrypt();
            }
        }

        private string OnEncrypt()
        {
            for (int i = 0; i < _msg.Length; i++)
            {
                int openMsg = (int)_msg[i];
                for (int j = 0; j < _alphabet.Length; j++)
                {
                    if (openMsg == _alphabet[j])
                    {
                        _encryption = _alphabet[(j + _shift) % _alphabet.Length];
                        _encryptedMsg += Char.ConvertFromUtf32(_encryption);
                        break;
                    }

                }
            }
            return _encryptedMsg;
        }

        private string OnDecrypt()
        {
            for (int i = 0; i < _msg.Length; i++)
            {
                int openMsg = (int)_msg[i];
                for (int j = 0; j < _alphabet.Length; j++)
                {
                    if (openMsg == (int)_alphabet[j])
                    {
                        _encryption = _alphabet[(j - _shift) % _alphabet.Length];
                        _decryptedMsg += Char.ConvertFromUtf32(_encryption);
                        break;
                    }
                }
            }
            return _decryptedMsg;
        }

        private bool MsgSeparate()
        {
            if (string.IsNullOrWhiteSpace(tb_msg.Text)) return false;
            _msg = tb_msg.Text;
            string[] pair = _msg.Split('/');
            _msg = pair[0];
            try 
            {
                _shift = int.Parse(pair[1]);
            }
            catch { tb_result.Text = "Внимание! Введено неверное значение сдвига."; return false; }
            if(_shift >= 1 && _shift <= 32) return true; 
            else tb_result.Text = "Внимание! Введено неверное значение сдвига."; return false;
        }
        #endregion

        #region Сохранение и загрузка из файла
        private void OnOpenFile(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            string path = file.FileName;
            StreamReader sr = new StreamReader(path);
            tb_msg.Text = sr.ReadToEnd() + "/10";
            sr.Close();
        }

        private void OnSaveFile(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Text Files | *.txt";
            file.ShowDialog();
            string path = file.FileName;
            StreamWriter sr = new StreamWriter(path);
            sr.Write(tb_msg.Text, Encoding.UTF8);
            sr.Close();
        }
        #endregion
    }
}
