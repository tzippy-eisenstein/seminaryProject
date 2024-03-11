namespace Gui_Ui_Pl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("הכנס מיקום", StringComparison.OrdinalIgnoreCase))
            {

                List<DTO_Enteties_PICO.TC> list = Bll.function.giveSourceAndContent(textBox2.Text);
                if (list != null && list.Count > 0)
                {
                    dataGridView1.DataSource = list;
                    textBox3.Text = list.Count.ToString();
                }

            }
            else { 
            List<DTO_Enteties_PICO.TC> list2 = Bll.function.giveSourceAndContent(textBox2.Text, textBox1.Text);

               if (list2 != null && list2.Count > 0)
               {
                  dataGridView1.DataSource = list2;
                  textBox3.Text = list2.Count.ToString();
               }
            }
            if(dataGridView1 != null) { 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Width
                = 100;
            dataGridView1.Height = 100;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //להכניס מיקום לחיפוש

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //להכניס מילה לחיפוש
        }
    }
}