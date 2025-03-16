namespace SlimmeLantaarnpaal
{
    public partial class Form1 : Form
    {
        private SensorWaarde sensor;
        private Lantaarnpaal lantaarnpaal1;
        private DatabaseManager dbManager;

        public Form1()
        {
            InitializeComponent();
            sensor = new SensorWaarde();
            lantaarnpaal1 = new Lantaarnpaal(1);
            dbManager = new DatabaseManager();
        }

        private void btnMeetLicht_Click(object sender, EventArgs e)
        {
            int lichtSterkte = sensor.LeesLichtwaarde();
            lblLichtsterkte.Text = $"Lichtsterkte: {lichtSterkte}";
            dbManager.OpslaanMeetgegevens(lantaarnpaal1.ID, lichtSterkte);

            if (lichtSterkte == 0) 
            {
                lantaarnpaal1.ZetAan(); 
                lblLantaarnpaal.Text = "Lantaarnpaal is AAN";
                pbLantaarnpaal.Image = Image.FromFile("lantaarnpaal_aan.jpg");
            }
            else if (lichtSterkte > 0)
            {
                lantaarnpaal1.ZetUit();
                lblLantaarnpaal.Text = "Lantaarnpaal is UIT";
                pbLantaarnpaal.Image = Image.FromFile("lantaarnpaal_uit.jpg");
            }
        }
    }
}
