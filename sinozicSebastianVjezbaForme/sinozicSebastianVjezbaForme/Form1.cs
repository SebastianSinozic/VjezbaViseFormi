using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinozicSebastianVjezbaForme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxStudenti.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta forma2 = new FormUnosNovogStudenta();
            forma2.ShowDialog();
        }

        private void buttonObrisiStudenta_Click(object sender, EventArgs e)
        {
            listBoxStudenti.ClearSelected();
        }
    }
}
