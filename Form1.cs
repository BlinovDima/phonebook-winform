using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhoneBook
{
    public partial class FormPhoneBook : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public FormPhoneBook()
        {
            InitializeComponent();
        }

        public void selectAllFromBd()
        {
            string connectonString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectonString);
            dbConnection.Open();
            string query = "SELECT w_id, w_name, w_number FROM Worker";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            listBoxMain.Items.Clear();

            int counter = 1;
            while (dbReader.Read())
            {
                // выводим данные столбцов текущей строки в listBox1
                listBoxMain.Items.Add("   " + (counter++) + ")" + "      Имя: "+ dbReader[1].ToString() + ";    Телефон: " + dbReader[2].ToString());
                listBoxMain.Items.Add("-----------------------------------------------------------------------------");
            }
            dbReader.Close();
            dbConnection.Close();
            lableCount.Text = (listBoxMain.Items.Count/2).ToString();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            selectAllFromBd();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string number = textBoxNumberPhone.Text;
            if (name == "Введите имя..." || number == "Введите номер телефона...")
            {
                MessageBox.Show("Заполнены не все поля!"+"\n"+"Заполните поля - Имя и Номер телефона","Ошибка заполнения формы!");
            }
            else
            {
                string connectonString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectonString);
                dbConnection.Open();
                string query = "INSERT INTO Worker (w_name,w_number) VALUES('" + name + "'," + number + ")";
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                if (dbCommand.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Ошибка выполнения запроса", "Ошибка");
                }
                else
                {
                    MessageBox.Show("Данные с (Именем " + name + " и Номером " + number + ") " + "добавлены в базу!", "Внимание!");
                }
                textBoxName.Clear();
                textBoxNumberPhone.Clear();
                dbConnection.Close();
                selectAllFromBd();
            }
            
        }

        private void FormPhoneBook_Load(object sender, EventArgs e)
        {
            buttonAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonAdd.Width, buttonAdd.Height, 20, 20));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            buttonDeleteByName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonDeleteByName.Width, buttonDeleteByName.Height, 20, 20));
            buttonDeleteByNumber.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonDeleteByNumber.Width, buttonDeleteByNumber.Height, 20, 20));
            buttonSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSearch.Width, buttonSearch.Height, 20, 20));
            buttonSearchByNumber.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSearchByNumber.Width, buttonSearchByNumber.Height, 20, 20));
            btnClearTextBoxByName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClearTextBoxByName.Width, btnClearTextBoxByName.Height, 20, 20));
            btnClearTextBoxSearchByNumber.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClearTextBoxSearchByNumber.Width, btnClearTextBoxSearchByNumber.Height, 20, 20));
            //placeholder Start
            textBoxName.Text           = "Введите имя...";
            textBoxName.ForeColor = Color.LightGray;
            textBoxNumberPhone.Text    = "Введите номер телефона...";
            textBoxNumberPhone.ForeColor = Color.LightGray;
            textBoxSearch.Text         = "Введите имя для поиска...";
            textBoxSearch.ForeColor = Color.LightGray;
            textBoxSearchByNumber.Text = "Введите номер для поиска...";
            textBoxSearchByNumber.ForeColor = Color.LightGray;
            textBoxDeleteByName.Text = "Введите имя для удаления...";
            textBoxDeleteByName.ForeColor = Color.LightGray;
            textBoxDeleteByNumber.Text = "Введите номер для удаления...";
            textBoxDeleteByNumber.ForeColor= Color.LightGray;
            //placeHolder End
            selectAllFromBd();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text;
            string connectonString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectonString);
            dbConnection.Open();
            string query = "SELECT w_id, w_name, w_number FROM Worker WHERE w_name = '"+searchText+"'";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            listBoxMain.Items.Clear();

            while (dbReader.Read())
            {
                // выводим данные столбцов текущей строки в listBox1
                listBoxMain.Items.Add("      Имя: " + dbReader[1].ToString() + ";    Телефон: " + dbReader[2].ToString());
            }

            dbReader.Close();
            dbConnection.Close();
        }

        private void buttonSearchByNumber_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearchByNumber.Text;
            string connectonString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectonString);
            dbConnection.Open();
            string query = "SELECT w_id, w_name, w_number FROM Worker WHERE w_number = '" + searchText + "'";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            listBoxMain.Items.Clear();

            while (dbReader.Read())
            {
                // выводим данные столбцов текущей строки в listBox1
                listBoxMain.Items.Add("      Имя: " + dbReader[1].ToString() + ";    Телефон: " + dbReader[2].ToString());
            }

            dbReader.Close();
            dbConnection.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Введите имя...")
               {
                    textBoxName.Text = "";
                    textBoxName.ForeColor = Color.Black;
               }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Введите имя...";
                textBoxName.ForeColor = Color.LightGray;
            }
        }

        private void textBoxNumberPhone_Enter(object sender, EventArgs e)
        {
            if (textBoxNumberPhone.Text == "Введите номер телефона...")
            {
                textBoxNumberPhone.Text = "";
                textBoxNumberPhone.ForeColor = Color.Black;
            }
        }

        private void textBoxNumberPhone_Leave(object sender, EventArgs e)
        {
            if (textBoxNumberPhone.Text == "")
            {
                textBoxNumberPhone.Text = "Введите номер телефона...";
                textBoxNumberPhone.ForeColor = Color.LightGray;
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Введите имя для поиска...")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Введите имя для поиска...";
                textBoxSearch.ForeColor = Color.LightGray;
            }
        }

        private void textBoxSearchByNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchByNumber.Text == "Введите номер для поиска...")
            {
                textBoxSearchByNumber.Text = "";
                textBoxSearchByNumber.ForeColor = Color.Black;
            }
        }

        private void textBoxSearchByNumber_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchByNumber.Text == "")
            {
                textBoxSearchByNumber.Text = "Введите номер для поиска...";
                textBoxSearchByNumber.ForeColor = Color.LightGray;
            }
        }

        private void textBoxDeleteByName_Enter(object sender, EventArgs e)
        {
            if (textBoxDeleteByName.Text == "Введите имя для удаления...")
            {
                textBoxDeleteByName.Text = "";
                textBoxDeleteByName.ForeColor = Color.Black;
            }
        }

        private void textBoxDeleteByName_Leave(object sender, EventArgs e)
        {
            if (textBoxDeleteByName.Text == "")
            {
                textBoxDeleteByName.Text = "Введите имя для удаления...";
                textBoxDeleteByName.ForeColor = Color.LightGray;
            }
        }

        private void textBoxDeleteByNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxDeleteByNumber.Text == "Введите номер для удаления...")
            {
                textBoxDeleteByNumber.Text = "";
                textBoxDeleteByNumber.ForeColor = Color.Black;
            }
        }

        private void textBoxDeleteByNumber_Leave(object sender, EventArgs e)
        {
            if (textBoxDeleteByNumber.Text == "")
            {
                textBoxDeleteByNumber.Text = "Введите номер для удаления...";
                textBoxDeleteByNumber.ForeColor = Color.LightGray;
            }
        }

        private void btnClearTextBoxByName_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
        }

        private void btnClearTextBoxSearchByNumber_Click(object sender, EventArgs e)
        {
            textBoxSearchByNumber.Text = "";
        }

        private void buttonDeleteByName_Click(object sender, EventArgs e)
        {
            string nameDelete = textBoxDeleteByName.Text;
            string connectonString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectonString);
            dbConnection.Open();
            string query = "DELETE FROM Worker WHERE w_name = '" + nameDelete + "'";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Ошибка выполнения запроса", "Ошибка");
            }
            else
            {
                MessageBox.Show("Данные с именем (" + nameDelete + " ) " + "удалены из базы!", "Внимание!");
            }
            textBoxDeleteByName.Clear();
            dbConnection.Close();
            selectAllFromBd();
        }

        private void buttonDeleteByNumber_Click(object sender, EventArgs e)
        {
            string numberDelete = textBoxDeleteByNumber.Text;
            string connectonString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectonString);
            dbConnection.Open();
            string query = "DELETE FROM Worker WHERE w_number = '" + numberDelete + "'";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Ошибка выполнения запроса", "Ошибка");
            }
            else
            {
                MessageBox.Show("Данные с номером (" + numberDelete + " ) " + "удалены из базы!", "Внимание!");
            }
            textBoxDeleteByNumber.Clear();
            dbConnection.Close();
            selectAllFromBd();
        }

        private void удалитьВсеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectonString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectonString);
            dbConnection.Open();
            string query = "DELETE FROM Worker";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            if (dbCommand.ExecuteNonQuery() != 1)
            {
                
                MessageBox.Show("Все данные удалены из базы!", "Внимание!");
            }
            else
            {
                MessageBox.Show("Ошибка выполнения запроса", "Ошибка");
            }
            
            dbConnection.Close();
            selectAllFromBd();
        }

        //Обработка печати
        private string resultPrint;
        public string viewListBox() 
            {
            for (int i = 0; i < listBoxMain.Items.Count; i++)
            {
                resultPrint += listBoxMain.Items[i] + Environment.NewLine;
            }
            return resultPrint; 
            }
        private void распечататьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            string resPrint = "Распечатка телефонной базы!";
            resultPrint = resPrint + "\n" + "\n" + viewListBox();

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintPreviewDialog printDialog = new PrintPreviewDialog();
            //PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;    
           

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(resultPrint, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Название: База телефонных номеров;\n" +
                            "Версия: 1.0.0;\n" +
                            "Основана на Базе данных от Access!","Справка");
        }
    }
}

