using System.IO;
namespace ControlCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FileInfo file = new FileInfo("vbbook.txt");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("vbbook.txt");
            if (file.Exists == false) //Если файл не существует
            {
                file.Create(); //Создаем
            }
            else MessageBox.Show("Файл уже создан!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("vbbook.txt");
            if (file.Exists == true) //Если файл существует
            {
                file.Delete(); //Удаляем
            }
            else MessageBox.Show("Файла не существует!!");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StreamWriter write_text;  //Класс для записи в файл
            FileInfo file = new FileInfo("vbbook.txt");
            write_text = file.AppendText(); //Дописываем инфу в файл, если файла не существует он создастся
            write_text.WriteLine(textBox1.Text); //Записываем в файл текст из текстового поля
            write_text.Close(); // Закрываем файл
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("vbbook.txt"); //Открываем файл для чтения
            string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
            while (!streamReader.EndOfStream) //Цикл длиться пока не будет достигнут конец файла
            {
                str += streamReader.ReadLine(); //В переменную str по строчно записываем содержимое файла
            }
            textBox1.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}