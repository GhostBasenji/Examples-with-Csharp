namespace SquareRoot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Text = "Извлечение квадратного корня";
            button1.Text = "Извлечь корень";
            textBox1.Clear();       // Очистка текстового поля
            label1.Text = null;     // или = String.Empty
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single X; // - из этого числа будем извлекать корень
            // Преобразование из строковой переменной в Single:
            bool IsTheNumber = Single.TryParse(
                textBox1.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo,
                out X);
            // Второй параметр – это разрешенный стиль числа (Integer,
            // шестнадцатеричное число, экспоненциальный вид числа и проч.).
            // Третий параметр форматирует значения на основе текущего языка 
            // и региональных параметров из Панели управления - Язык и 
            // региональные стандарты числа допустимого формата: метод возвращает значение в переменную X
            if (IsTheNumber == false)
            {
                // Если пользователь ввел не число:
                label1.Text = "Следует вводить числа!";
                label1.ForeColor = Color.Red;
                return; // - выход из процедуры или Return
            }
            // Извлечение корня с преобразованием в тип Single:
            var Y = (Single)Math.Sqrt(X);
            // или var Y = Convert.ToSingle(Math.Sqrt(X));
            label1.ForeColor = Color.Black;
            label1.Text = String.Format("Корень из {0} равен {1:F5}", X, Y);
        }
    }
}