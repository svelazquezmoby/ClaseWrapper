using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseWrapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EngineWrapper ewrap = new EngineWrapper();
            ewrap.UpdateRPM = "1200";
            ewrap.PrintRPM();
            ewrap.PrintString();
        }
        class Engine
        {
            private string RPM;
            public string Rpmstring
            {
                get { return RPM; }
                set { RPM = value; }
            }
            public void PrintRPM()
            {
                MessageBox.Show(RPM);
            }
        }

        class EngineWrapper
        {
            private Engine engine;  
            public EngineWrapper()
            {
                engine = new Engine();  
            }
            public string UpdateRPM
            {
                get { return engine.Rpmstring; }
                set { engine.Rpmstring = value; }
            }
            public void PrintRPM()
            {
                engine.PrintRPM();
            }
            public void PrintString()
            {
                MessageBox.Show("local string");
            }
        }
    }
}
