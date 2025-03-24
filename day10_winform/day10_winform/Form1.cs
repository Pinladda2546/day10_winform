namespace day10_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gettext = question_text.Text;
            string[] string_values = gettext.Split("x");
            double a, b, c;
            a = Convert.ToDouble(string_values[0]);
            b = Convert.ToDouble(string_values[1]);
            c = a * b;
            solution_textbox.Text = c.ToString();
            solution_label.Text = c.ToString();
        }
    }
}
