using CesarCipher.Classes;
using System.Text;
using System.Text.RegularExpressions;

namespace CesarCipher.Forms
{
    public partial class DefaultMode : Form
    {
        #region Поля
        private string _msg = "";
        private int _shift = 0;
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
                tb_result.Text = "";
                tb_result.Text = Encrypter.OnEncrypt(_msg, _shift);
            }
            else if (((Button)sender).Name == "bt_DecryptMsg")
            {
                tb_result.Text = "";
                tb_result.Text = Encrypter.OnDecrypt(_msg, _shift);
            }
        }

        private bool MsgSeparate()
        {
            if (string.IsNullOrWhiteSpace(tb_msg.Text)) return false;
            foreach (char ch in tb_msg.Text)
            {
                if ((int)ch >= 97 && (int)ch <= 122)
                {
                    tb_result.Text = "Внимание! Используйте только русские буквы!";
                    return false;
                }
            }
            _msg = tb_msg.Text;
            string[] pair = _msg.Split('/');
            _msg = pair[0];
            try 
            {
                _shift = int.Parse(pair[1]);
            }
            catch { tb_result.Text = "Внимание! Введено неверное значение сдвига."; return false; }
            if(_shift >= 1 && _shift <= 31) return true; 
            else tb_result.Text = "Внимание! Введено неверное значение сдвига."; return false;
        }

        #endregion

        #region Сохранение и загрузка из файла
        private void OnOpenFile(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Files | *.txt";
            file.ShowDialog();
            string path = file.FileName;
            if(string.IsNullOrWhiteSpace(path)) return;
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
            if (string.IsNullOrWhiteSpace(path)) return;
            StreamWriter sr = new StreamWriter(path);
            sr.Write(tb_result.Text, Encoding.UTF8);
            sr.Close();
        }
        #endregion
    }
}
