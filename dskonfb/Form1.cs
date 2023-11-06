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

            int vysledek = 0;
            int pocitadlo = 0;
            while (pocitadlo < bincis.Length)
            {
                double vypocet = bincis[bincis.Length-pocitadlo-1] * Math.Pow(2, pocitadlo);
                MessageBox.Show((bincis[bincis.Length - pocitadlo - 1]).ToString());
                vysledek += Convert.ToInt32(vypocet);
                pocitadlo++;
            }

            return vysledek;
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