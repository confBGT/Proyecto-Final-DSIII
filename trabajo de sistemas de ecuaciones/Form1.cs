namespace trabajo_de_sistemas_de_ecuaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sistemas2x2 form = new Sistemas2x2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistema3x3 form = new Sistema3x3();
            form.Show();
        }
    }
}
