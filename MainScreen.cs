namespace Clockeate
{
    public partial class MainScreen : Form
    {
        public void Clockeate()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.Timelabel.Text = dateTime.ToString();
        }
    }
}
