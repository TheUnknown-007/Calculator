using System;
using System.Threading;
using System.Windows.Forms;

namespace Calculator
{
    public class ProgramHandler : ApplicationContext
    {
        public enum CalculatorType {
            Standard,
            Scientific
        }
        public static CalculatorType calcType = CalculatorType.Standard;

        public ProgramHandler()
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();

            DialogResult? result = null;
            //form1.Show();
            switch (calcType)
            {
                case CalculatorType.Standard:
                    result = form1.ShowDialog();
                    break;
                case CalculatorType.Scientific:
                    result = form2.ShowDialog();
                    break;
            }

            while (result == DialogResult.Retry)
            {
                switch (calcType)
                {
                    case CalculatorType.Standard:
                        result = form1.ShowDialog();
                        break;
                    case CalculatorType.Scientific:
                        result = form2.ShowDialog();
                        break;
                }
            }

            Environment.Exit(0);
        }
    }

    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ProgramHandler context = new ProgramHandler();
            Application.Run(context);
        }
    }
}
