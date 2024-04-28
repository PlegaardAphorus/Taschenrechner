namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddNewText(string input)
        {
            string tmp = tbx_calculation.Text;
            tbx_calculation.Text = tmp + input;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            AddNewText("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            AddNewText("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            AddNewText("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            AddNewText("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            AddNewText("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            AddNewText("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            AddNewText("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            AddNewText("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            AddNewText("9");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddNewText("+");
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            AddNewText("-");
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            AddNewText("*");
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            AddNewText("/");
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            tbx_calculation.Text = "";
        }
    }
}