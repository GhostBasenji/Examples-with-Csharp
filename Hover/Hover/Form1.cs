namespace Hover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Процедура обработки события загрузки формы
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Microsoft Visual C#";
            button1.Text = "Нажми меня";
            base.Text = "Приветствие";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Всем привет!");
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Событие Hover!");
        }
    }
}