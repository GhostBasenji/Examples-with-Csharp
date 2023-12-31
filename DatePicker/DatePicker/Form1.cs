namespace DatePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Обработка события загрузки формы:
            this.Text = "Средство выбора даты";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "ddd, dd MMM, yyyy";
            button1.Text = "Выбрать дату:";
            label1.Text = String.Format("Сегодня: {0}", dateTimePicker1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Обработка события нажатия на кнопку
            // Передаем фокус на элемент управления dateTimePicker1:
            dateTimePicker1.Focus();
            // Имитируем нажатие клавиши F4:
            SendKeys.Send("{F4}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Обработка события изменения даты:
            label1.Text = String.Format("Выбранная дата: {0}", dateTimePicker1.Text);
        }
    }
}