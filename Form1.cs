namespace codigoProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        
        
        {
        
            // Afegim els elements al primer control ListBox
            listBox1.Items.Add("Informàtica");
            listBox1.Items.Add("Administració i gestió");
            listBox1.Items.Add("Disseny");
            listBox1.Items.Add("Educació social");
            // Verifiquem si s'ha seleccionat l'element "Informàtica"
            if (listBox1.SelectedItem.ToString() == "Informàtica")
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
