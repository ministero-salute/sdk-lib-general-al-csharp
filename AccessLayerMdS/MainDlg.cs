using AccessLayerMdS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessLayerMdS
{
    public partial class MainDlg : Form
    {
        private string FileNameDPM_SingelRecord;
        private string FileNameLog;

        public MainDlg()
        {
            InitializeComponent();
        }
        private void MainDlg_Load(object sender, EventArgs e)
        {
            textBoxHost.Text = "http://localhost:8080";

            try
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
                string version = fvi.FileVersion;

                this.Text += "  v. " + version;

                FileNameLog = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\LogAccessLayer.txt";
            }
            catch
            {

            }

            radioButtonDPM_CheckedChanged(null, null);
        }
        private void linkLabelFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "CSV file (*.csv)|*.csv|XML Files|*.xml|file firmato (*.p7m)|*.p7m";
            openFileDialog.DefaultExt = "csv";
            openFileDialog.FilterIndex = 0;
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            FileNameDPM_SingelRecord = openFileDialog.FileName;
            textBoxFile.Text = openFileDialog.SafeFileName;
        }
        private void buttonFileFlux_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxDisplay.Text = "";

                int IdClient = 0;
                try
                {
                    IdClient = Int32.Parse(textBoxIdClient.Text);
                }
                catch { }

                ModOp mod = radioButtonTest.Checked ? ModOp.Test : ModOp.Produzione;

                ResultFlux result = new ResultFlux();

                if (radioButtonDIR.Checked)
                {
                    DIR.AccessLayer accessLayer = new DIR.AccessLayer();
                    //accessLayer.Init(textBoxHost.Text, FileNameLog);
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonDPM.Checked)
                {
                    DPM.AccessLayer accessLayer = new DPM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    DPM.ResultSendFile resultAPI1 = accessLayer.SendFile(textBoxIdClient.Text, textBoxFile.Text);
                    richTextBoxDisplay.AppendText(resultAPI1.ToLog());
                    richTextBoxDisplay.ScrollToCaret();
                    return;
                }
                else if (radioButtonSALMVig.Checked)
                {
                    SALM.VIG.AccessLayer accessLayer = new SALM.VIG.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSALMPnr.Checked)
                {
                    SALM.PNR.AccessLayer accessLayer = new SALM.PNR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSALMPsd.Checked)
                {
                    SALM.PSD.AccessLayer accessLayer = new SALM.PSD.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSISMRes.Checked)
                {
                    SISM.RES.AccessLayer accessLayer = new SISM.RES.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSISMSemires.Checked)
                {
                    SISM.SEMIRES.AccessLayer accessLayer = new SISM.SEMIRES.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSISMTer.Checked)
                {
                    SISM.TER.AccessLayer accessLayer = new SISM.TER.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonAVN_NSM.Checked)
                {
                    AVN.NSM.AccessLayer accessLayer = new AVN.NSM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonAVN_NSR.Checked)
                {
                    AVN.NSR.AccessLayer accessLayer = new AVN.NSR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonAVN_SM.Checked)
                {
                    AVN.SM.AccessLayer accessLayer = new AVN.SM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonAVN_SR.Checked)
                {
                    AVN.SR.AccessLayer accessLayer = new AVN.SR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonEMURPS.Checked)
                {
                    EMURPS.AccessLayer accessLayer = new EMURPS.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonDISPOVIG.Checked)
                {
                    DISPOVIG.AccessLayer accessLayer = new DISPOVIG.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendFlux(IdClient, textBoxFile.Text, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }

                richTextBoxDisplay.AppendText(result.ToLog());
                richTextBoxDisplay.ScrollToCaret();
            }
            catch(Exception excep)
            {
                richTextBoxDisplay.AppendText(excep.Message);
                richTextBoxDisplay.ScrollToCaret();
            }
        }
        private void buttonSingleRecord_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxDisplay.Text = "";

                int IdClient = 0;
                try
                {
                    IdClient = Int32.Parse(textBoxIdClient.Text);
                }
                catch { }

                ModOp mod = radioButtonTest.Checked ? ModOp.Test : ModOp.Produzione;

                ResultSingleRecord result = new ResultSingleRecord();

                if (radioButtonDIR.Checked)
                {
                    DIR.AccessLayer accessLayer = new DIR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    DIR.Record record = new DIR.Record()
                    {
                        AnnoDiRiferimento = 2022,
                        AslAssistito = "AslAssistito",
                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonDPM.Checked)
                {
                    DPM.AccessLayer accessLayer = new DPM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    DPM.Record record = GetRecordFromFile();

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSALMVig.Checked)
                {
                    SALM.VIG.AccessLayer accessLayer = new SALM.VIG.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    SALM.VIG.Record record = new SALM.VIG.Record()
                    {
                        
                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSALMPnr.Checked)
                {
                    SALM.PNR.AccessLayer accessLayer = new SALM.PNR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    SALM.PNR.Record record = new SALM.PNR.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSALMPsd.Checked)
                {
                    SALM.PSD.AccessLayer accessLayer = new SALM.PSD.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    SALM.PSD.Record record = new SALM.PSD.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSISMRes.Checked)
                {
                    SISM.RES.AccessLayer accessLayer = new SISM.RES.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    SISM.RES.Record record = new SISM.RES.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSISMSemires.Checked)
                {
                    SISM.SEMIRES.AccessLayer accessLayer = new SISM.SEMIRES.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    SISM.SEMIRES.Record record = new SISM.SEMIRES.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonSISMTer.Checked)
                {
                    SISM.TER.AccessLayer accessLayer = new SISM.TER.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    SISM.TER.Record record = new SISM.TER.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonAVN_NSM.Checked)
                {
                    AVN.NSM.AccessLayer accessLayer = new AVN.NSM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    AVN.NSM.Record record = new AVN.NSM.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonAVN_NSR.Checked)
                {
                    AVN.NSR.AccessLayer accessLayer = new AVN.NSR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    AVN.NSR.Record record = new AVN.NSR.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonAVN_SM.Checked)
                {
                    AVN.SM.AccessLayer accessLayer = new AVN.SM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    AVN.SM.Record record = new AVN.SM.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonAVN_SR.Checked)
                {
                    AVN.SR.AccessLayer accessLayer = new AVN.SR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    AVN.SR.Record record = new AVN.SR.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonEMURPS.Checked)
                {
                    EMURPS.AccessLayer accessLayer = new EMURPS.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    EMURPS.Record record = new EMURPS.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }
                else if (radioButtonDISPOVIG.Checked)
                {
                    DISPOVIG.AccessLayer accessLayer = new DISPOVIG.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    DISPOVIG.Record record = new DISPOVIG.Record()
                    {

                    };

                    result = accessLayer.SendSingleRecord(IdClient, record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }

                richTextBoxDisplay.AppendText(result.ToLog());
                richTextBoxDisplay.ScrollToCaret();
            }
            catch (Exception excep)
            {
                richTextBoxDisplay.AppendText(excep.Message);
                richTextBoxDisplay.ScrollToCaret();
            }
        }
        private void buttonGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxDisplay.Text = "";

                int IdClient = 0;
                int IdRun = 0;
                try
                {
                    IdClient = Int32.Parse(textBoxIdClient.Text);
                }
                catch { }
                try
                {
                    IdRun = Int32.Parse(textBoxIdRun.Text);
                }
                catch { }

                ResultGetInfo result = new ResultGetInfo();

                if (radioButtonDIR.Checked)
                {
                    DIR.AccessLayer accessLayer = new DIR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonDPM.Checked)
                {
                    DPM.AccessLayer accessLayer = new DPM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonSALMVig.Checked)
                {
                    SALM.VIG.AccessLayer accessLayer = new SALM.VIG.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonSALMPnr.Checked)
                {
                    SALM.PNR.AccessLayer accessLayer = new SALM.PNR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonSALMPsd.Checked)
                {
                    SALM.PSD.AccessLayer accessLayer = new SALM.PSD.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonSISMRes.Checked)
                {
                    SISM.RES.AccessLayer accessLayer = new SISM.RES.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonSISMSemires.Checked)
                {
                    SISM.SEMIRES.AccessLayer accessLayer = new SISM.SEMIRES.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonSISMTer.Checked)
                {
                    SISM.TER.AccessLayer accessLayer = new SISM.TER.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonAVN_NSM.Checked)
                {
                    AVN.NSM.AccessLayer accessLayer = new AVN.NSM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonAVN_NSR.Checked)
                {
                    AVN.NSR.AccessLayer accessLayer = new AVN.NSR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonAVN_SM.Checked)
                {
                    AVN.SM.AccessLayer accessLayer = new AVN.SM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonAVN_SR.Checked)
                {
                    AVN.SR.AccessLayer accessLayer = new AVN.SR.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonEMURPS.Checked)
                {
                    EMURPS.AccessLayer accessLayer = new EMURPS.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }
                else if (radioButtonDISPOVIG.Checked)
                {
                    DISPOVIG.AccessLayer accessLayer = new DISPOVIG.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.GetInfo(IdClient, IdRun);
                }

                richTextBoxDisplay.AppendText(result.ToLog());
                richTextBoxDisplay.ScrollToCaret();
            }
            catch (Exception excep)
            {
                richTextBoxDisplay.AppendText(excep.Message);
                richTextBoxDisplay.ScrollToCaret();
            }
        }
        private void buttonVerificaStato_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxDisplay.Text = "";

                if (radioButtonDPM.Checked)
                {
                    StateVerifyDlg dlg = new StateVerifyDlg();
                    dlg.ShowDialog();

                    if (!dlg.send)
                        return;

                    DPM.AccessLayer accessLayer = new DPM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    DPM.ResultStateVerify result = accessLayer.StateVerify(
                        dlg.identificativoSoggettoAlimentante,
                        dlg.regioneSoggettoAlimentante,
                        dlg.cap,
                        dlg.codiceSoggettoAlimentante,
                        dlg.indirizzo
                        );

                    richTextBoxDisplay.AppendText(result.ToLog());
                    richTextBoxDisplay.ScrollToCaret();
                }
            }
            catch (Exception excep)
            {
                richTextBoxDisplay.AppendText(excep.Message);
                richTextBoxDisplay.ScrollToCaret();
            }
        }
        private void buttonClearOutput_Click(object sender, EventArgs e)
        {
            richTextBoxDisplay.Text = "";
        }
        private void radioButtonDPM_CheckedChanged(object sender, EventArgs e)
        {
            buttonSingleRecord.Enabled = radioButtonDPM.Checked;
            buttonVerificaStato.Enabled = radioButtonDPM.Checked;
            buttonGetInfo.Enabled = !radioButtonDPM.Checked;
            linkLabelJSON.Enabled = radioButtonDPM.Checked;
        }
        private void linkLabelJSON_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JsonDlg dlg = new JsonDlg();
            dlg.record = GetRecordFromFile();
            dlg.ShowDialog();

            if (!dlg.Invia)
                return;

            try
            {
                richTextBoxDisplay.Text = "";

                int IdClient = 0;
                try
                {
                    IdClient = Int32.Parse(textBoxIdClient.Text);
                }
                catch { }

                ModOp mod = radioButtonTest.Checked ? ModOp.Test : ModOp.Produzione;

                ResultSingleRecord result = new ResultSingleRecord();

                if (radioButtonDPM.Checked)
                {
                    DPM.AccessLayer accessLayer = new DPM.AccessLayer();
                    accessLayer.Init(textBoxHost.Text);

                    result = accessLayer.SendSingleRecord(IdClient, dlg.record, mod, textBoxAnnoRif.Text, textBoxPeriodoRif.Text, textBoxCodReg.Text);
                }

                richTextBoxDisplay.AppendText(result.ToLog());
                richTextBoxDisplay.ScrollToCaret();
            }
            catch (Exception excep)
            {
                richTextBoxDisplay.AppendText(excep.Message);
                richTextBoxDisplay.ScrollToCaret();
            }
        }

        private DPM.Record GetRecordFromFile()
        {
            DPM.Record record = new DPM.Record();

            if(string.IsNullOrEmpty(FileNameDPM_SingelRecord))
                return record;

            try
            {
                using (StreamReader sr = new StreamReader(FileNameDPM_SingelRecord))
                {
                    string line = sr.ReadLine();
                    string[] headers = line.Split('~');

                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        string[] rows = line.Split('~');

                        record.donatoreMinorenne = rows[0];
                        record.tipoAtto = rows[1];
                        record.tipoDisponente = rows[2];
                        record.formatoAtto = rows[3];
                        record.donatoreLuogoNascitaCodiceNazione = rows[4];
                        record.donatoreLuogoNascitaCodiceRegione = rows[5];
                        record.donatoreLuogoNascitaCodiceProvincia = rows[6];
                        record.donatoreLuogoNascitaCodiceComune = rows[7];
                        record.donatoreLuogoResidenzaCodiceNazione = rows[8];
                        record.donatoreLuogoResidenzaCodiceRegione = rows[9];
                        record.donatoreLuogoResidenzaCodiceProvincia = rows[10];
                        record.donatoreLuogoResidenzaCodiceComune = rows[11];
                        record.donatoreNome = rows[12];
                        record.donatoreCognome = rows[13];
                        record.donatoreCF = rows[14];
                        record.donatoreDataNascita = rows[15];
                        record.donatoreIndirizzoResidenza = rows[16];
                        record.donatoreCapResidenza = rows[17];
                        record.disponenti1ConsensoEmail = rows[18];
                        record.disponenti1LuogoNascitaCodiceNazione = rows[19];
                        record.disponenti1LuogoNascitaCodiceRegione = rows[20];
                        record.disponenti1LuogoNascitaCodiceProvincia = rows[21];
                        record.disponenti1LuogoNascitaCodiceComune = rows[22];
                        record.disponenti1LuogoResidenzaCodiceNazione = rows[23];
                        record.disponenti1LuogoResidenzaCodiceRegione = rows[24];
                        record.disponenti1LuogoResidenzaCodiceProvincia = rows[25];
                        record.disponenti1LuogoResidenzaCodiceComune = rows[26];
                        record.disponenti1Nome = rows[27];
                        record.disponenti1Cognome = rows[28];
                        record.disponenti1CF = rows[29];
                        record.disponenti1DataNascita = rows[30];
                        record.disponenti1IndirizzoResidenza = rows[31];
                        record.disponenti1CapResidenza = rows[32];
                        record.disponenti1Email = rows[33];
                        record.disponenti2ConsensoEmail = rows[34];
                        record.disponenti2LuogoNascitaCodiceNazione = rows[35];
                        record.disponenti2LuogoNascitaCodiceRegione = rows[36];
                        record.disponenti2LuogoNascitaCodiceProvincia = rows[37];
                        record.disponenti2LuogoNascitaCodiceComune = rows[38];
                        record.disponenti2LuogoResidenzaCodiceNazione = rows[39];
                        record.disponenti2LuogoResidenzaCodiceRegione = rows[40];
                        record.disponenti2LuogoResidenzaCodiceProvincia = rows[41];
                        record.disponenti2LuogoResidenzaCodiceComune = rows[42];
                        record.disponenti2Nome = rows[43];
                        record.disponenti2Cognome = rows[44];
                        record.disponenti2CF = rows[45];
                        record.disponenti2DataNascita = rows[46];
                        record.disponenti2IndirizzoResidenza = rows[47];
                        record.disponenti2CapResidenza = rows[48];
                        record.disponenti2Email = rows[49];
                        record.fiduciari1ConsensoEmail = rows[50];
                        record.fiduciari1LuogoNascitaCodiceNazione = rows[51];
                        record.fiduciari1LuogoNascitaCodiceRegione = rows[52];
                        record.fiduciari1LuogoNascitaCodiceProvincia = rows[53];
                        record.fiduciari1LuogoNascitaCodiceComune = rows[54];
                        record.fiduciari1LuogoResidenzaCodiceNazione = rows[55];
                        record.fiduciari1LuogoResidenzaCodiceRegione = rows[56];
                        record.fiduciari1LuogoResidenzaCodiceProvincia = rows[57];
                        record.fiduciari1LuogoResidenzaCodiceComune = rows[58];
                        record.fiduciari1Nome = rows[59];
                        record.fiduciari1Cognome = rows[60];
                        record.fiduciari1CF = rows[61];
                        record.fiduciari1DataNascita = rows[62];
                        record.fiduciari1IndirizzoResidenza = rows[63];
                        record.fiduciari1CapResidenza = rows[64];
                        record.fiduciari1Email = rows[65];
                        record.fiduciari2ConsensoEmail = rows[66];
                        record.fiduciari2LuogoNascitaCodiceNazione = rows[67];
                        record.fiduciari2LuogoNascitaCodiceRegione = rows[68];
                        record.fiduciari2LuogoNascitaCodiceProvincia = rows[69];
                        record.fiduciari2LuogoNascitaCodiceComune = rows[70];
                        record.fiduciari2LuogoResidenzaCodiceNazione = rows[71];
                        record.fiduciari2LuogoResidenzaCodiceRegione = rows[72];
                        record.fiduciari2LuogoResidenzaCodiceProvincia = rows[73];
                        record.fiduciari2LuogoResidenzaCodiceComune = rows[74];
                        record.fiduciari2Nome = rows[75];
                        record.fiduciari2Cognome = rows[76];
                        record.fiduciari2CF = rows[77];
                        record.fiduciari2DataNascita = rows[78];
                        record.fiduciari2IndirizzoResidenza = rows[79];
                        record.fiduciari2CapResidenza = rows[80];
                        record.fiduciari2Email = rows[81];
                        record.soggettoAlimentanteRegioneSoggettoAlimentante = rows[82];
                        record.soggettoAlimentanteCap = rows[83];
                        record.soggettoAlimentanteCodiceSoggettoAlimentante = rows[84];
                        record.soggettoAlimentanteIndirizzo = rows[85];
                        record.idSoggettoAlimentante = rows[86];
                        record.dataSottoscrizione = rows[87];

                        break;
                    }
                }
            }
            catch(Exception excep)
            {
                richTextBoxDisplay.Text = "";
                richTextBoxDisplay.AppendText(excep.Message);
                richTextBoxDisplay.ScrollToCaret();
            }

            return record;
        }
    }
}
