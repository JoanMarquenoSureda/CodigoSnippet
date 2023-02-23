namespace codigoProyecto
{
    public partial class Form1 : Form
    {
        int currentImageIndex = 0;
        public Form1()
        {
            InitializeComponent();
            // afegir imatges a la llista d'imatges
            

            // establir la imatge inicial de la PictureBox
            pictureBox1.Image = imageList1.Images[currentImageIndex];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        
        
        {
        
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // incrementar l'índex de la imatge actual
            currentImageIndex++;

            // si arribem al final de la llista d'imatges, tornem a la primera imatge
            if (currentImageIndex >= imageList1.Images.Count)
            {
                currentImageIndex = 0;
            }

            // actualitzar la imatge de la PictureBox amb la següent imatge de la llista
            pictureBox1.Image = imageList1.Images[currentImageIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
