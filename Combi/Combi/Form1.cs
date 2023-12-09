namespace Combi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Калькулятор"; label1.Text = "Равно: ";
            button1.Text = "Выбери операцию";
            comboBox1.Text = "Выбери операцию";

            // Заполняем (инициализируем) раскрывающийся список:
            string[] Operations = { "Прибавить", "Отнять", "Умножить", "Разделить", "Очистить" };
            comboBox1.Items.AddRange(Operations);
            comboBox1.TabIndex = 2;
            textBox1.Clear(); textBox1.TabIndex = 0;
            textBox2.Clear(); textBox2.TabIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обрабатываем событие изменения индекса выбранного элемента
            label1.Text = "Равно: ";

            // Преобразование из строковой переменной в Single:
            Single X, Y, Z; Z = 0;

            var Chislo_1 = Single.TryParse(textBox1.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo,
                out X);
            var Chislo_2 = Single.TryParse(textBox2.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo,
                out Y);
            if (Chislo_1 == false || Chislo_2 == false)
            {
                MessageBox.Show("Следует вводить числа!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // если ошибка, то выходим из процедуры
            }
            // Оператор множественного выбора
            switch (comboBox1.SelectedIndex)
            {
                // Выбор арифметической операции:
                case 0: // Выбрали "Прибавить"
                    Z = X + Y; break;
                case 1: // Выбрали "Отнять"
                    Z = X - Y; break;
                case 2: // Выбрали "Умножить"
                    Z = X * Y; break;
                case 3: // Выбрали "Разделить"
                    Z = X / Y; break;
                case 4: // // Выбрали "Очистить"
                    textBox1.Clear(); textBox2.Clear();
                    label1.Text = "Равно: "; return;
            }
            label1.Text = String.Format("Равно: {0:F5}", Z);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // "Принудительно" раскрываем список:
            comboBox1.DroppedDown = true;
        }
    }
}