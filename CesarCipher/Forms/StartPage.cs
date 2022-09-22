using CesarCipher.Forms;

namespace CesarCipher
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void ShowButtonInfo(object sender, MouseEventArgs e)
        {
            switch(((Button)sender).Name)
            {
                case "bt_defaultMode":
                    tb_btInfo.Text = $"������ '{((Button)sender).Text}' ��������� ����, � ������� �� ������ ��������� ���������� � ����������� ������ ��������� � ����������� ���������� ����� (������).";
                    break;
                case "bt_bruteforceMode":
                    tb_btInfo.Text = $"������ '{((Button)sender).Text}' ��������� ����, � ������� �� ������ ���������� ����� �� ������������� ��������� ����� '������ ����'.";
                    break;
                case "bt_freqAnalysis":
                    tb_btInfo.Text = $"������ '{((Button)sender).Text}' ��������� ����, � ������� �� ������ ���������� ����� �� ������������� ��������� ����� ���������� �������.";
                    break;
                default:
                    break;
            }
        }

        private void LoadDefaultModePage(object sender, EventArgs e)
        {
            DefaultMode defaultMode = new DefaultMode();
            defaultMode.ShowDialog();
            defaultMode.Dispose();
        }

        private void LoadBruteforcePage(object sender, EventArgs e)
        {
            Bruteforce bruteforce = new Bruteforce();
            bruteforce.ShowDialog();
            bruteforce.Dispose();
        }

        private void LoadFreqAnalysisPage(object sender, EventArgs e)
        {

        }
    }
}