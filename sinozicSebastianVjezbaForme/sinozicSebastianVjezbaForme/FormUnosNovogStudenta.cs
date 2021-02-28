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
    public partial class FormUnosNovogStudenta : Form
    {
        public FormUnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void comboBoxSmjer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta forma2 = new FormUnosNovogStudenta();
            this.Close();
            forma2.Close();
        }
    }
}
