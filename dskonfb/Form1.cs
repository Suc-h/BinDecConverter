using System.Windows.Forms;

namespace dskonfb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string DecToBin(int n)
        {
            string bincis = String.Empty;
            int help = 0;
            while (n > 0)
            {
                help = n % 2;
                bincis = help + bincis;
                n = n / 2;
            }
            return bincis;
        }
        int BinToDec(string bincis)
        {

            double vysl = 0;
            while (bincis.Length > 0)
            {
                if (bincis[0] == '1')
                {
                    vysl += Math.Pow(2, bincis.Length - 1);
                }
                bincis = bincis.Substring(1);
            }
            return Convert.ToInt32(vysl);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)numericUpDown1.Value;
                label1.Text = DecToBin(n);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string n = textBox1.Text;
                label2.Text = BinToDec(n).ToString();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar < '0')|| e.KeyChar>'9')&& e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }
    }
}