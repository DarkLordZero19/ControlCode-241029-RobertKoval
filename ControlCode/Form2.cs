using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCode
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputFilePath = @"c:\proba\probin.txt";
            if (File.Exists(inputFilePath))
            {
                using (StreamReader reader = new StreamReader(inputFilePath, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден: " + inputFilePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string outputFilePath = @"c:\proba\probout.txt";
            using (StreamWriter writer = new StreamWriter(outputFilePath, false, Encoding.UTF8))
            {
                foreach (string line in listBox1.Items)
                {
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int maxWordLength = 0;
                    int maxWordCount = 0;

                    foreach (string word in words)
                    {
                        if (word.Length > maxWordLength)
                        {
                            maxWordLength = word.Length;
                            maxWordCount = 1;
                        }
                        else if (word.Length == maxWordLength)
                        {
                            maxWordCount++;
                        }
                    }

                    StringBuilder result = new StringBuilder();
                    result.AppendLine(line);
                    result.AppendFormat("Максимальная длина слова: {0}, количество слов максимальной длины: {1}", maxWordLength, maxWordCount);
                    listBox2.Items.Add(result.ToString());
                    writer.WriteLine(result.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
