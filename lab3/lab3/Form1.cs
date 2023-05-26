namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
            listBox1.Items.Add(textBox3.Text);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
            listBox1.Items.Add(textBox3.Text);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
            listBox1.Items.Add(textBox3.Text);
        }

        private void divided_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
            listBox1.Items.Add(textBox3.Text);

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(textBox3.Text);
        }

        
    }
}