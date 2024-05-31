namespace WFA240531_01
{
    public partial class Form1 : Form
    {
        static Random rnd = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Resize(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helló Világ!");
        }
    }
}
