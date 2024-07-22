using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessLayerMdS
{
    public partial class StateVerifyDlg : Form
    {
        public string identificativoSoggettoAlimentante;
        public string regioneSoggettoAlimentante;
        public string cap;
        public string codiceSoggettoAlimentante;
        public string indirizzo;
        public bool send;

        public StateVerifyDlg()
        {
            InitializeComponent();

            send = false;
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            identificativoSoggettoAlimentante = textBoxidentificativoSoggettoAlimentante.Text;
            regioneSoggettoAlimentante = textBoxregioneSoggettoAlimentante.Text;
            cap = textBoxcap.Text;
            codiceSoggettoAlimentante = textBoxcodiceSoggettoAlimentante.Text;
            indirizzo = textBoxindirizzo.Text;

            send = true;
            Close();
        }
    }
}
