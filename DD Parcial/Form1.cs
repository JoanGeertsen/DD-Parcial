namespace DD_Parcial
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FCarga carga = new FCarga();
            carga.Show();
        }
    }
}