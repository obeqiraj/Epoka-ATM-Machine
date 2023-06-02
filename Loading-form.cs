namespace Loading_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width > 777)
            {
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }
        }
    }
}