namespace Práctica_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;                       //Se declaran las variables a usar.
            cal = double.Parse(textBox1.Text);           //Se declara que la calificación será la que escribamos en la caja1.
            if (cal < 3.0) MessageBox.Show("Reprobado"); else MessageBox.Show("Aprobado");    //Se aplica un condicional que activará un cuadro de texto que dirá reprobado o aprobado dependiendo si se cumple o no.
            
                

            


        }




    }
}
