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
            if (file.Exists == false) //���� ���� �� ����������
            {
                file.Create(); //�������
            }
            else MessageBox.Show("���� ��� ������!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("vbbook.txt");
            if (file.Exists == true) //���� ���� ����������
            {
                file.Delete(); //�������
            }
            else MessageBox.Show("����� �� ����������!!");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StreamWriter write_text;  //����� ��� ������ � ����
            FileInfo file = new FileInfo("vbbook.txt");
            write_text = file.AppendText(); //���������� ���� � ����, ���� ����� �� ���������� �� ���������
            write_text.WriteLine(textBox1.Text); //���������� � ���� ����� �� ���������� ����
            write_text.Close(); // ��������� ����
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("vbbook.txt"); //��������� ���� ��� ������
            string str = ""; //��������� ����������, � ������� ����� ���������� ����� �� �����
            while (!streamReader.EndOfStream) //���� ������� ���� �� ����� ��������� ����� �����
            {
                str += streamReader.ReadLine(); //� ���������� str �� ������� ���������� ���������� �����
            }
            textBox1.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}