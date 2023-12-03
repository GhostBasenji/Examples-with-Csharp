namespace CheckBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Флажок CheckBox";
            checkBox1.Text = "Полужирный"; checkBox1.Focus();
            checkBox2.Text = "Наклонный";
            label1.Text = "Выбери стиль шрифта";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new Font("Courier New", 14.0F);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Courier New", 14.0F, label1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Courier New", 14.0F, label1.Font.Style ^ FontStyle.Italic);
        }
    }
}