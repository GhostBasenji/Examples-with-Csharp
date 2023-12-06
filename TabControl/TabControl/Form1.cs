namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Создаем третью вкладку "программно":
            var tabPage3 = new TabPage();
            tabPage3.UseVisualStyleBackColor = true;

            // Добавляем третью вкладку в существующий набор вкладок tabControl:
            this.tabControl1.Controls.Add(tabPage3);

            // Создаем и добавляем переключатели 5 и 6 в третью вкладку:
            var radioButton5 = new RadioButton();
            var radioButton6 = new RadioButton();
            tabPage3.Controls.Add(radioButton5);
            tabPage3.Controls.Add(radioButton6);

            // Расположим переключателей 5 и 6:
            radioButton5.Location = new Point(20, 15);
            radioButton6.Location = new Point(20, 58);

            // Создаем обработчики событий для переключатей 5 и 6
            radioButton5.CheckedChanged += new System.EventHandler(radioButton5_CheckedChanged);
            radioButton6.CheckedChanged += new System.EventHandler(radioButton6_CheckedChanged);

            // Задаем название формы
            this.Text = "Какая улыбка Вам ближе";

            // Задаем названия вкладок:
            tabControl1.TabPages[0].Text = "Текст";
            tabControl1.TabPages[1].Text = "Цвет";
            tabControl1.TabPages[2].Text = "Размер";

            // Эта пара переключателей изменяет текст:
            radioButton1.Text = "Восхищенная, сочувственная, " + "\n" + "скромно-смущенная";
            radioButton2.Text = "Нежная улыбка, ехидная, бес" + "стыжая, " + "\n" + "подленькая, снисходительная";
            // или
            // radioButton2.Text = "Нежная улыбка, бесстыжая," + Environment.NewLine + "подленькая, снисходительная";

            // Эта пара переключателей изменяет цвет текста:
            radioButton3.Text = "Красный";
            radioButton4.Text = "Синий";

            // Эта пара переключателей изменяет размер шрифта:
            radioButton5.Text = "13 пунктов";
            radioButton6.Text = "15 пунктов";

            label1.Text = radioButton1.Text;
        }

        // Ниже обрабатываем события изменения состояния шести переключателей
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Consolas", 13.0f);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 15.0F);
        }
    }
}