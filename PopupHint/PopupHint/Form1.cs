// Программа пишет в метку Label некоторый текст, а пользователь
// с помощью кнопки делает этот текст либо видимым, либо
// невидимым. Здесь используется свойство Visible. При зависании мыши
// над кнопкой появляется подсказка "Переключатель видимости"
namespace PopupHint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Обрабатываем событие "загрузка формы"
            this.Text = "Житейская мудрость";
            label1.Text =
                "Сколько ребенка ни учи хорошим манерам," + "\n" +
                "он будет поступать так, как папа с мамой";
            // label1.TextAlingn = ContentAlignment.MiddleCenter;
            button1.Text = "Кнопка";

            // Создаем элемент управления toolTip и задаем ему событие
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Active = true;
            toolTip1.SetToolTip(this.button1, "Переключатель" + "\n" + "видимости");
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Обработка события "щелчок на кнопке":

                // Можно программировать так:
                // if (label1.Visible == true) label1.Visible = false;
                // else label1.Visible = true;
                // или так:
                // label1.Visible = label1.Visible ^ true;

                // Или самый простой вариант:
                label1.Visible = !label1.Visible;
        }
    }
}