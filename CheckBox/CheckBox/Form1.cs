namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Text = "Флажок CheckBox";
            checkBox1.Text = "Полужирный"; checkBox1.Focus();
            label1.Text = "Выбери стиль шрифта";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new Font("Courier New", 10.0F);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Изменение состояния флажка на противоположное
            if (checkBox1.Checked == true) label1.Font =
             new Font("Courier New", 14.0F, FontStyle.Bold);
            if (checkBox1.Checked == false) label1.Font =
            new Font("Courier New", 14.0F, FontStyle.Regular);
        }
    }
}