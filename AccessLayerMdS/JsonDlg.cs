using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessLayerMdS
{
    public partial class JsonDlg : Form
    {
        public DPM.Record record;
        public bool Invia = false;

        public JsonDlg()
        {
            InitializeComponent();
        }
        private void JsonDlg_Load(object sender, EventArgs e)
        {
            Invia = false;

            if (record == null)
            {
                richTextBoxDisplay.AppendText("Record Vuoto");
                richTextBoxDisplay.ScrollToCaret();
                return;
            }

            try
            {
                string json = JsonSerializer.Serialize(record);

                json = json.Replace("\",\"", "\",\n\"");

                richTextBoxDisplay.AppendText(json);
                richTextBoxDisplay.ScrollToCaret();
            }
            catch (Exception excep)
            {
                richTextBoxDisplay.AppendText(excep.Message);
                richTextBoxDisplay.ScrollToCaret();
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Invia = true;

            try
            {
                record = JsonSerializer.Deserialize<DPM.Record>(richTextBoxDisplay.Text);
                Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
    }
}
