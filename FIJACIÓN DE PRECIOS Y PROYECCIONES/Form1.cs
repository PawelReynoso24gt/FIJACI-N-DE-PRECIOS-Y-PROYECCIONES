namespace FIJACIÓN_DE_PRECIOS_Y_PROYECCIONES
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFijacionVentas formFijacion = new FormFijacionVentas();
            formFijacion.Show();
        }

        private void buttonBase_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBase1 formBase1 = new FormBase1();
            formBase1.Show();
        }

        private void buttonProyeccion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProyecciones formProyecciones = new FormProyecciones();
            formProyecciones.Show();
        }
    }
}