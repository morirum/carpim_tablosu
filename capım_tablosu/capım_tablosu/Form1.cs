namespace capım_tablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int c = 1 ; c < 10; c++) 
            {
                for (int r = 1; r < 11; r++)
                {
                    listBox1.Items.Add(c + "x" + r+ "=" + c * r);
                }
                listBox1.Items.Add("***************************");
            
            }



        }
    }
}