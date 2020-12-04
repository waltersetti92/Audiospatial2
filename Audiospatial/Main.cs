using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Newtonsoft.Json;
using System.Threading;


namespace Audiospatial
{
    public delegate void ResumeFromMessage();
    public partial class Main : Form
    {
        public static readonly string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string resourcesPath1 = Path.GetDirectoryName(Application.ExecutablePath) + "\\resources1";
        public static readonly string resourcesPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\resources";
        public static readonly string resultsDir = Path.GetDirectoryName(Application.ExecutablePath) + "\\results";
        private const string background_image = "Buco_Nero.jpg";
        private const string background_image_stanza = "bedsingle.png";
        private const string background_image_trafficjam = "trafficjam.png";
        private const string background_image_plane = "plane3.png";
        private const string background_image_tribal = "popolazione.png";
        private const string background_image_lion = "lion1.png";
        private const string background_image_maya = "temple.png";
        private const string activities_json = "activities.json";
        private readonly ActivityMathSpatialAudio activity;
        private readonly Activities activitiesList;
        private UserControl currUC = null;
        private UserControl currUC1 = null;
        public SoundPlayer player = null;
        public static readonly int N_SPEAKERS = 3;
        public static readonly bool IS_DEBUG = false;
        public int onactivity;
        public int messaggio;
        public int participants;
        public int iDifficulty = 0;
        public int scenario;
        public int ripetiz = 0;
        ResumeFromMessage message_callback = null;
        public Speakers speakers = null;
        public Main()
        {
            onactivity = 1;
            messaggio = 1;
            scenario = 1;
            participants = 0;
            speakers = new Speakers();
            InitializeComponent();                       
            initial1.parentForm = this;
            activityUdaUC1.parentForm = this;
            primo_Scenario1.parentForm = this;
            debugInfo1.parentForm = this;
            answerUC1.parentForm = this;
            activity_Stanza1.parentForm = this;
            secondo_Scenario1.parentForm = this;
            messageUC1.parentForm = this;
            terzo_Scenario1.parentForm = this;
            quarto_Scenario1.parentForm = this;
            quinto_Scenario1.parentForm = this;
            sesto_Scenario1.parentForm = this;
            ucSpeaker1.parentForm = this;
            final1.parentForm = this;
            finale_Scenario1.parentForm = this;
            initial1.Visible = false;
            activityUdaUC1.Visible = false;
            primo_Scenario1.Visible = false;
            debugInfo1.Visible = false;
            answerUC1.Visible = false;
            activity_Stanza1.Visible = false;
            messageUC1.Visible = false;
            secondo_Scenario1.Visible = false;
            terzo_Scenario1.Visible = false;
            quarto_Scenario1.Visible = false;
            quinto_Scenario1.Visible = false;
            sesto_Scenario1.Visible = false;
            ucSpeaker1.Visible = false;
            final1.Visible = false;
            finale_Scenario1.Visible = false;
            ucSpeaker1.init(speakers);
            home();
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Image.FromFile(resourcesPath + "\\" + background_image);

            activitiesList = readActivitiesList();
            activity = new ActivityMathSpatialAudio(activitiesList, this, speakers, activity_Stanza1, debugInfo1);
        }
        private Activities readActivitiesList()
        {
            /*var jsonString = @"{""items"":[[{""difficulty"":2, ""id"":1, ""operands"":[1,2,3,4], ""operations"":[0,1,2]}, {""difficulty"":0, ""id"":2, ""operands"":[1,2,3,4], ""operations"":[0,1,2]}]]}";*/
            using (StreamReader file = File.OpenText(resourcesPath + "\\" + activities_json))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (Activities)serializer.Deserialize(file, typeof(Activities));
            }
        }

        public void piu_partecipanti()

        {
            currUC.Visible = false;
            ripetiz = 1;
            messageUC1.setMessage("GRAZIE DI AVER PARTECIPATO !!! tocca al tuo compagno", "comincia");
        }
        public void closeMessage1()
        {
            messageUC1.Visible = false;
            activity_Stanza1.Visible = true;
            message_callback?.Invoke();
        }
        public void finale()
        {
            if (currUC != null) currUC.Visible = false;
            finale_Scenario1.Show();
            currUC = finale_Scenario1;
        }
        public void home()
        {
            if (currUC != null) currUC.Visible = false;
            initial1.Show();
            currUC = initial1;
        }
        public void scenes()
        {
            if (currUC != null) currUC.Visible = false;
            if (onactivity == 2)
            {
                secondo_Scenario1.Show();
                currUC1 = secondo_Scenario1;
            }
            else if (onactivity == 3)
            {
                terzo_Scenario1.Show();
                currUC1 = terzo_Scenario1;
            }
            else if (onactivity == 4)
            {
                quarto_Scenario1.Show();
                currUC1 = quarto_Scenario1;
            }
            else if (onactivity ==5)
            {
                quinto_Scenario1.Show();
                currUC1 = quinto_Scenario1;
            }
            else if (onactivity == 6)
            {
                sesto_Scenario1.Show();
                currUC1 = sesto_Scenario1;
            }

        }

        public void onStart()
        {
            initial1.Visible = false;
            activityUdaUC1.Visible = true;
            currUC = activityUdaUC1;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Size size = this.Size; //commit
            initial1.setPos(size.Width, size.Height);
            activityUdaUC1.setPos(size.Width, size.Height);
            primo_Scenario1.setPos(size.Width, size.Height);
            answerUC1.setPos(size.Width, size.Height);
            activity_Stanza1.setPos(size.Width, size.Height);
            messageUC1.setPos(size.Width, size.Height);
            secondo_Scenario1.setPos(size.Width, size.Height);
            terzo_Scenario1.setPos(size.Width, size.Height);
            quarto_Scenario1.setPos(size.Width, size.Height);
            quinto_Scenario1.setPos(size.Width, size.Height);
           sesto_Scenario1.setPos(size.Width, size.Height);
            finale_Scenario1.setPos(size.Width, size.Height);
        }
        public void onStartActivity(int level, int type, int num_participants, string group)
        {
            if (onactivity==1)
            {
                activityUdaUC1.Visible = false;
               BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_stanza);
                speakers.sound_speaker = "13 09 ";
                speakers.sound_time = " 09 ";
                speakers.reinitSpeakers();                
                primo_Scenario1.Visible = true;
            }
           else if (onactivity == 2)
            {
                messageUC1.Visible = false;
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_trafficjam);
                speakers.sound_speaker = "0A 03 ";
                speakers.sound_time = " 03 ";
                speakers.reinitSpeakers();
                secondo_Scenario1.Visible = true;
            }
            else if (onactivity == 3)
            {
                messageUC1.Visible = false;
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_plane);
                speakers.sound_speaker = "12 09 ";
                speakers.sound_time = " 09 ";
                speakers.reinitSpeakers();
                terzo_Scenario1.Visible = true;
            }
            else if (onactivity == 4)
            {
                messageUC1.Visible = false;
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_tribal);
                speakers.sound_speaker = "10 0E ";
                speakers.sound_time = " 10 ";
                speakers.reinitSpeakers();
                quarto_Scenario1.Visible = true;
            }
            else if (onactivity == 5)
            {
                messageUC1.Visible = false;
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_lion);
                speakers.sound_speaker = "0E 09 ";
                speakers.sound_time = " 0A ";
                speakers.reinitSpeakers();
                quinto_Scenario1.Visible = true;
            }
            else if (onactivity == 6)
            {
                messageUC1.Visible = false;
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_maya);
                speakers.sound_speaker = "07 0A ";
                speakers.sound_time = " 0A ";
                speakers.reinitSpeakers();
                sesto_Scenario1.Visible = true;
            }

            iDifficulty = level;
            participants = num_participants;

           if (Main.IS_DEBUG == true) debugInfo1.Visible = true;
           else debugInfo1.Visible = false;

            currUC = activity_Stanza1;
            onactivity++;

            activity.init(level, type, num_participants, group);
        }
        public void closeMessage()
        {
            if (onactivity == 2)
            {
                primo_Scenario1.Visible = false;
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_stanza);         
               
            }
            else if (onactivity == 3)
            {
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_trafficjam);
                secondo_Scenario1.Visible = false;
            }
            else if (onactivity == 4)
            {
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_plane);
                terzo_Scenario1.Visible = false;
            }
            else if (onactivity == 5)
            {
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_tribal);
                quarto_Scenario1.Visible = false;
            }
            else if (onactivity == 6)
            {
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_lion);
                quinto_Scenario1.Visible = false;
            }
            else if (onactivity == 7)
            {
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(resourcesPath1 + "\\" + background_image_maya);
                sesto_Scenario1.Visible = false;
            }
            currUC.Visible = true;
            message_callback?.Invoke();
        }
        public void onAnswer(string result)
        {
            answerUC1.Visible = false;
            if (activity.isCorrect(Int32.Parse(result))) playbackResourceAudio("success");
            else playbackResourceAudio("failure");

            Thread.Sleep(2000);
            activity.nextOperand();
            currUC = activity_Stanza1;
        }
        public void onEndActivities()
        {
            currUC.Visible = false;
            if (onactivity == 2)
            {
                messageUC1.setMessage("Complimenti !!! Avete svegliato Hinrik! Ora corriamo all'aeroporto!", "continua");                
            }
            else if (onactivity == 3)
            {
                messageUC1.setMessage("Complimenti !!! Siete arrivati all'aeroporto! Saliamo sull'aereo e partiamo!", "continua");
            }
            else if (onactivity == 4)
            {
                messageUC1.setMessage("Complimenti !!! Il viaggio è andato a buon fine!", "continua");
            }
            else if (onactivity == 5)
            {
                messageUC1.setMessage("Complimenti !!! La popolazione ti ha suggerito dove trovare il tesoro!", "continua");
            }
            else if (onactivity == 6)
            {
                messageUC1.setMessage("Complimenti !!! Hai superato l'ostacolo del leone! Recupera il tesoro", "continua");
            }
            else if (onactivity == 7)
            {
                messageUC1.setMessage("Complimenti !!! Hai recuperato il reperto!", "continua");
               // this.Visible = false;
             //   finale_Scenario1.Visible=true;
              //  currUC = finale_Scenario1;
              
            }
            message_callback = scenes;
        }
        public void showMessage(string msg, string bt_text, ResumeFromMessage clb = null)
        {
            currUC.Visible = false;
            message_callback = clb;
            if (messaggio == 1)
                primo_Scenario1.setMessage_ps(bt_text);
            else if (messaggio == 2)
                secondo_Scenario1.setMessage_ps(bt_text);
            else if (messaggio == 3)
                terzo_Scenario1.setMessage_ps(bt_text);
            else if (messaggio == 4)
                quarto_Scenario1.setMessage_ps(bt_text);
            else if (messaggio == 5)
                quinto_Scenario1.setMessage_ps(bt_text);
            else if (messaggio == 6)
                sesto_Scenario1.setMessage_ps(bt_text);
            else if (messaggio == 7)
                finale_Scenario1.Visible = true;
        }
        public void onCountDownEnd()
        {
            activity_Stanza1.Visible = false;
            debugInfo1.Visible = false;

            answerUC1.show(iDifficulty);
            answerUC1.Visible = true;
            currUC = answerUC1;
        }
        public void playbackResourceAudio(string audioname)
        {

            string s = resourcesPath + "\\" + audioname + ".wav";
            player = new SoundPlayer(s);
            player.Play();
        }

        private void initial1_Load(object sender, EventArgs e)
        {

        }

        private void quinto_Scenario1_Load(object sender, EventArgs e)
        {

        }

        private void final1_Load(object sender, EventArgs e)
        {

        }

        private void btTestSpeakers_Click(object sender, EventArgs e)
        {
            
        }

        private void finale_Scenario1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ucSpeaker1.Visible = true;
        }
    }
}
