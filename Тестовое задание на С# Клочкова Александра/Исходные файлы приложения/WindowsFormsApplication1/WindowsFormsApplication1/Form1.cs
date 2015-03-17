using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static string a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog myFile = new OpenFileDialog();

            myFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";// Установка ограничения по выбору расширения файла
            if (myFile.ShowDialog() == DialogResult.OK)// Проверка загрузки файла
            {
                a = myFile.FileName;// Присваивание переменной значения выбранного файла
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog myFile = new OpenFileDialog();
            myFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";// Установка ограничения по выбору расширения файла
            if (myFile.ShowDialog() == DialogResult.OK)// Проверка загрузки файла
            {
                b = myFile.FileName;// Присваивание переменной значения выбранного файла
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((a == null) && (b == null))
            {
                MessageBox.Show("Выберите файлы для загрузки. (Выполните пункты 1-2)");
            }
            else
            {
                if (a == null)
                {
                    MessageBox.Show("Файл с текстом не загружен. (Выполните пункт 1)");
                }
                else
                {
                    if (b == null)
                    {
                        MessageBox.Show("Словарь не загружен. (Выполните пункт 2)");
                    }
                    else
                    {
                        string[] s2 = File.ReadAllLines(b, Encoding.GetEncoding("windows-1251")); // Создание массива и считывание содержимого файла  
                        FileStream file1 = new FileStream("d:\\myprogramma.html", FileMode.Create); //Создание нового файла
                        c = "d:\\myprogramma.html";
                        StreamWriter writer = new StreamWriter(file1, Encoding.GetEncoding("windows-1251"));// Соединение файлового потока с "Потоковым писателем"          
                        FileInfo file = new FileInfo(a);
                        long size = file.Length;
                        writer.Write("<!DOCTYPE HTML>");
                        writer.Write("<html><head>");
                        writer.Write("<title>Тестовое задание Клочкова Александра</title>");
                        writer.Write("</head>");
                        writer.Write("<body>");
                        writer.Write("<div><p>");
                        if (size > 2100000)
                        {
                            MessageBox.Show("Возникла ошибка при загрузке файла. Файл превышает допустимый размер (2 Мб)");
                        }
                        else
                        {
                            MessageBox.Show("Загрузка файла произведена успешно.");
                            string[] OurText = File.ReadAllLines(a, Encoding.GetEncoding("windows-1251")); // Создание массива и считывание содержимого файла
                            List<string> EndText = new List<string>();
                            bool flag = false;
                            foreach (string str in OurText)   //Просмотр одна за одной всех строк в тексте
                            {
                                string[] slovo = str.Split(' '); // Разбиение строки на слова и запись в массив
                                for (int i = 0; i < slovo.Length; i++) // Организация цикла, обрабатывающего содержимое массива до конца файла
                                {
                                    flag = false;
                                    for (int j = 0; j < s2.Length; j++)// Организация цикла для проверки условия равенства слов
                                    {
                                        if (slovo[i] == s2[j])// Проверка слов. Если слова равны, то
                                        {
                                            writer.Write("<strong><em>" + slovo[i] + "</em></strong>" + " ");//Замена слова из файла с текстом на слово из словаря
                                            flag = true;
                                        }
                                    }
                                    if (flag != true)
                                    {
                                        writer.Write(slovo[i] + " "); // Если слово из файла с текстом не равно слову из словаря, то замены не происходит
                                    }

                                }
                                writer.Write("<br>");// Переход на следующую строку в файле с текстом
                            }


                        }
                        writer.Write("<p></div>");
                        writer.Write("</body>");
                        writer.Write("</html>");


                        writer.Close();// Закрытие файлового потока
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c == "d:\\myprogramma.html") // Проверка наличия файла
            {
                System.Diagnostics.Process.Start("d:\\myprogramma.html");//Если файл существует - открытие его в браузере 
            }
            else
            {
                MessageBox.Show("Файл, который Вы пытаетесь загрузить, не найден. Убедитесь в его существовании.");// Если файл отсутствует - соответствуеющее сообщение 
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void загрузитеФайлСТекстомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog myFile = new OpenFileDialog();

            myFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";// Установка ограничения по выбору расширения файла
            if (myFile.ShowDialog() == DialogResult.OK)// Проверка загрузки файла
            {
                a = myFile.FileName;// Присваивание переменной значения выбранного файла
            }
        }

        private void загрузитеФайлСловаряToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog myFile = new OpenFileDialog();
            myFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";// Установка ограничения по выбору расширения файла
            if (myFile.ShowDialog() == DialogResult.OK)// Проверка загрузки файла
            {
                b = myFile.FileName;// Присваивание переменной значения выбранного файла
            }
        }

        private void записатьФайлыВHTMLдокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((a == null) && (b == null))
            {
                MessageBox.Show("Выберите файлы для загрузки. (Выполните пункты 1-2)");
            }
            else
            {
                if (a == null)
                {
                    MessageBox.Show("Файл с текстом не загружен. (Выполните пункт 1)");
                }
                else
                {
                    if (b == null)
                    {
                        MessageBox.Show("Словарь не загружен. (Выполните пункт 2)");
                    }
                    else
                    {
                        string[] s2 = File.ReadAllLines(b, Encoding.GetEncoding("windows-1251")); // Создание массива и считывание содержимого файла  
                        FileStream file1 = new FileStream("d:\\myprogramma.html", FileMode.Create); //Создание нового файла
                        c = "d:\\myprogramma.html";
                        StreamWriter writer = new StreamWriter(file1, Encoding.GetEncoding("windows-1251"));// Соединение файлового потока с "Потоковым писателем"          
                        FileInfo file = new FileInfo(a);
                        long size = file.Length;
                        writer.Write("<!DOCTYPE HTML>");
                        writer.Write("<html><head>");
                        writer.Write("<title>Тестовое задание Клочкова Александра</title>");
                        writer.Write("</head>");
                        writer.Write("<body>");
                        writer.Write("<div><p>");
                        if (size > 2100000)
                        {
                            MessageBox.Show("Возникла ошибка при загрузке файла. Файл превышает допустимый размер (2 Мб)");
                        }
                        else
                        {
                            MessageBox.Show("Загрузка файла произведена успешно.");
                            string[] OurText = File.ReadAllLines(a, Encoding.GetEncoding("windows-1251")); // Создание массива и считывание содержимого файла
                            List<string> EndText = new List<string>();
                            bool flag = false;
                            foreach (string str in OurText)   //Просмотр одна за одной всех строк в тексте
                            {
                                string[] slovo = str.Split(' '); // Разбиение строки на слова и запись в массив
                                for (int i = 0; i < slovo.Length; i++) // Организация цикла, обрабатывающего содержимое массива до конца файла
                                {
                                    flag = false;
                                    for (int j = 0; j < s2.Length; j++)// Организация цикла для проверки условия равенства слов
                                    {
                                        if (slovo[i] == s2[j])// Проверка слов. Если слова равны, то
                                        {
                                            writer.Write("<strong><em>" + slovo[i] + "</em></strong>" + " ");//Замена слова из файла с текстом на слово из словаря
                                            flag = true;
                                        }
                                    }
                                    if (flag != true)
                                    {
                                        writer.Write(slovo[i] + " "); // Если слово из файла с текстом не равно слову из словаря, то замены не происходит
                                    }

                                }
                                writer.Write("<br>");// Переход на следующую строку в файле с текстом
                            }


                        }
                        writer.Write("<p></div>");
                        writer.Write("</body>");
                        writer.Write("</html>");


                        writer.Close();// Закрытие файлового потока
                    }
                }
            }
        }

        private void открытьWebстраницуВБраузереToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (c == "d:\\myprogramma.html") // Проверка наличия файла
            {
                System.Diagnostics.Process.Start("d:\\myprogramma.html");//Если файл существует - открытие его в браузере 
            }
            else
            {
                MessageBox.Show("Файл, который Вы пытаетесь загрузить, не найден. Убедитесь в его существовании.");// Если файл отсутствует - соответствуеющее сообщение 
            }
        }

        private void просмотрСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа очень проста в использовании!Для ее правильной, вам нужно для начала нажать клавишу (1.Загрузить файл с текстом) и выбрать нужный вам файл с текстом.=>>>Потом нажать клавишу для загрузки файла словаря (2.Загрузить файл словаря)и выбрать файл (Slovar.txt).=>>>Далее нажать клавишу (3.Записать файлы в HTML-документ).=>>>И затем нажмите (4.Открыть HTML-документ в браузере).Если вы все сделали правильно приложение выдаст вам нужную html-страницу. Аналогичные действия можно проделать через контекстное меню программы.Клавиша (Выход) закроет приложение.Также можно найти в контекстном меню информацию о приложении.<<<=Спасибо за внимание!!!=>>>  ", "Help");
        }

        private void информацияОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа была выполненна Клочковым Александром, с целью выполнения тестового задания", "info");
        }

    }
}
