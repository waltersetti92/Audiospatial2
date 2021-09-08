using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Audiospatial
{
    public partial class AnswerUC : UserControl
    {
        public Main parentForm { get; set; }
        private int iDifficulty = 0;
        public int timeleft = 2;
        public string k;
        public string put_wait_data;
        public string put_started;
        public string get_status_uda;
        public AnswerUC()
        {
            InitializeComponent();
            btAnswer.Visible = false;
            txtResult.Visible = false;
            put_started = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/put/?i=1&k=7";
            put_wait_data = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/put/?i=1&k=14" + "&data=" + "{\"answer\": \"Inserisci il risultato corretto\", \"input_type\":\"\"}";
            get_status_uda = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/get/?i=1";
        }
        public void setPos(int w, int h)
        {
            Location = new Point(w / 2 - Width / 2, h / 2 - Height / 2);
        }
        internal void show(int diff = 0)
        {
            iDifficulty = diff;
            Visible = true;
            txtResult.Text = "";
            txtResult.Select();
        }
        private void txtResult_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (txtResult.Text.Length > 0)
                    parentForm.onAnswer(txtResult.Text);
            }
        }

        private string representNumber(int number)
        {
            if (number == -1) return "";

          return number.ToString();
        }


        private void AnswerUC_Load(object sender, EventArgs e)
        {

        }

        private void btAnswer_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
                parentForm.onAnswer(txtResult.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerlabel_Click(object sender, EventArgs e)
        {

        }
        public void counter()
        {
            timerlabel.Visible = true;
            timerlabel.Text = "10";
            timeleft = 2;
            timer1.Enabled = true;
            timer1.Start();
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {

            if (timeleft > 0)
            {
                while (true)
                {
                    k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);

                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            Application.Exit();
                            Environment.Exit(0);
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        if (status==10)
                        {
                            await uda_server_communication.Server_Request(put_wait_data);
                        }
                        Thread.Sleep(1000);
                        timeleft = timeleft - 1;
                        timerlabel.Text = timeleft.ToString();
                        this.Update();
                        while (true)
                        {
                            if (status == 15)
                            {
                                string data = await uda_server_communication.Server_Request_datasent(get_status_uda);
                                timerlabel.Visible = false;
                                timer1.Stop();
                                timerlabel.Visible = false;
                                timer1.Enabled = false;
                                await uda_server_communication.Server_Request(put_started);
                                parentForm.onAnswer(data);                              
                            }
                            break;
                        }
                        break;
                    }
                }

            }
            if (timeleft == 0)
            {
                string data1 = "900";
                timerlabel.Visible = false;
                parentForm.onAnswer(data1);
                timer1.Enabled = false;
                Thread.Sleep(1000);
                await uda_server_communication.Server_Request(put_started);                
                //Thread.Sleep(2000);               
            }
        }
    }
}
