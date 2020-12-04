using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Audiospatial
{
    public partial class ucSpeaker : UserControl
    {
        public Main parentForm { get; set; }
        private Speakers speakers = null;
        private string[] availableComs;

        public ucSpeaker()
        {
            InitializeComponent();

            lbEastConnected.Text = "disconnected";
            lbWestConnected.Text = "disconnected";
            lbNorthConnected.Text = "disconnected";
        }
        public void init(Speakers spk)
        {
            speakers = spk;
            availableComs = Speakers.getAvailableComs();
            foreach (string com in availableComs)
                cmbCom.Items.Add(com);

            if (cmbCom.Items.Count > 0)
                cmbCom.SelectedIndex = 0;
        }

        private void btWest_Click(object sender, EventArgs e)
        {
            speakers.startSpeaker(Speakers.available_speakers[0]);
        }

        private void btNorth_Click(object sender, EventArgs e)
        {
            speakers.startSpeaker(Speakers.available_speakers[1]);
        }

        private void btEast_Click(object sender, EventArgs e)
        {
            speakers.startSpeaker(Speakers.available_speakers[2]);
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            speakers.startSpeaker(Speakers.available_speakers[0]);
            Thread.Sleep(1500);

            speakers.startSpeaker(Speakers.available_speakers[1]);
            Thread.Sleep(1500);

            speakers.startSpeaker(Speakers.available_speakers[2]);
            Thread.Sleep(1500);
        }

        private void btSetCom_Click(object sender, EventArgs e)
        {
            string text = cmbCom.SelectedItem.ToString();
            System.IO.File.WriteAllText(speakers.comFile, text);

            speakers = speakers.openPort(text);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            speakers.reinitSpeakers();
        }

        private void ucSpeaker_Load(object sender, EventArgs e)
        {

        }

        private void cmbCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }
    }
}
