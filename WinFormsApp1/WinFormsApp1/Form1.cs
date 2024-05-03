using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                double dzielna = Convert.ToDouble(dzielnaTextBox.Text);
                double dzielnik = Convert.ToDouble(dzielnikTextBox.Text);

               
                if (dzielnik == 0)
                {
                    throw new Exception("Dzielnik nie mo¿e byæ zerem!");
                }

                
                double wynik = dzielna / dzielnik;

                
                wynikTextBox.Text = wynik.ToString();
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Podano nieprawid³ow¹ liczbê!");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);

                
                EventLog myLog = new EventLog();
                myLog.Source = "Application";
                myLog.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
        }

    }
}
