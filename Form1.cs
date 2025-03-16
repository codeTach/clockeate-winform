namespace Clockeate
{
    public partial class Form1 : Form
    {
        public void Clockeate()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.Timelabel.Text = dateTime.ToString();
        }
    }
}
