using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlapok
{
    public partial class WindowsForm : Form
    {
        public WindowsForm()
        {
            InitializeComponent();
        }

        private void Button_Betoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "Adatfájl neve:";
            openFileDialog1.InitialDirectory=Environment.CurrentDirectory;
            openFileDialog1.ShowDialog(this);
        }
    }
}
