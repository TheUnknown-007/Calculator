
using System.Windows.Forms;

namespace Calculator
{
    public partial class ParentForm : Form
    {
        Form1 standardForm = new Form1();
        Form2 scientificForm = new Form2();
        public ParentForm()
        {
            this.Hide();
            standardForm.Show();
            standardForm.Hide();
            standardForm.Show();
            
            /*var DataSettings = new IniFile("Settings.ini");
            if (!DataSettings.KeyExists("DefaultMode", "General"))
            {
                DataSettings.Write("DefaultMode", "Standard", "General");
                Form1 form = new Form1();
                DialogResult result = form.ShowDialog();
                if(result == DialogResult.Retry) { }
            }
            else
            {
                if(DataSettings.Read("DefaultMode", "General") == "Scientific")
                {
                    Form2 form = new Form2();
                    form.ShowDialog();
                }
                else
                {
                    Form1 form = new Form1();
                    DialogResult result = form.ShowDialog();
                }
            }*/
        }

        public static void openStandard()
        {

        }

        public static void openScientific()
        {
            
        }
    }
}
