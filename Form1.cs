namespace codigoProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            // Afegim els elements al primer control ListBox
            listBox1.Items.Add("Inform�tica");
            listBox1.Items.Add("Administraci� i gesti�");
            listBox1.Items.Add("Disseny");
            listBox1.Items.Add("Educaci� social");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifiquem si s'ha seleccionat l'element "Inform�tica"
            if (listBox1.SelectedItem.ToString() == "Inform�tica")
            {
                // Configurem el segon control ListBox
                listBox2.Items.Clear();
                listBox2.Items.Add("DAM");
                listBox2.Items.Add("DAW");
                listBox2.Items.Add("ASIX");
                listBox2.Visible = true;
            } else
            {
                listBox2.Visible = false;
            }
            

        }
    }
}