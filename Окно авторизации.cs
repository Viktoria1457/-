using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace практика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string pravo;

            private void button1_Click_1(object sender, EventArgs e)
            {
            //обявляем оперторов
            string username = Login.Text;
            string password = Password.Text;
            //соединяем программу с баззой чтобы данные из таблицы были доступны при окно авторизации
            SqlConnection sqlConnect = new SqlConnection("Data Source=DESKTOP-NIEVM4B\\SQLEXPRESS07;Initial Catalog=Практика;Trusted_Connection=True");

            try
            {
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Данные_Сотрудников_Организации where Логин = @login", sqlConnect);
                da.SelectCommand.Parameters.AddWithValue("@login", username);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Пользователь с таким логином не существует.");
                    
                }
                else
                {
                    string dbPassword = dt.Rows[0]["Пароль"].ToString();
                    string role = dt.Rows[0]["Долженность"].ToString();
                    Контроль_выполнения_заказов view = new Контроль_выполнения_заказов(role);
                    if (password == dbPassword)
                    {
                        //Раздача прав доступа с дальнейшим переключем на нужную форму
                        switch (role)
                        {
                            case "Администратор":
                                MessageBox.Show("Произведён вход как администратор");
                                Меню_для_Администратора admin = new Меню_для_Администратора();
                                admin.Show();
                                this.Hide();
                                
                                
                                break;
                            case "Директор":
                                MessageBox.Show("Произведён вход как Директор");
                                Form4 Директор = new Form4();
                                Директор.Show();
                                this.Hide();
                                view.Show();


                                break;
                            case "Работник":
                                MessageBox.Show("Произведён вход как Рабочий");
                                Form5 рабочий  = new Form5();
                                рабочий.Show();
                                this.Hide();
                                
                                break;
                            case "Клиент":
                                MessageBox.Show("Произведён вход как Клиент");
                                Form2 Клиент = new Form2();
                                Клиент.Show();
                                this.Hide();
                                
                                break;

                        }


                    }
                    //команда в случае неверного введения пароля или логина
                    else
                    {
                        MessageBox.Show("Неверный Пароль.");
                    }
                }
            }
            //команда если данного пользователя нет в системе
            catch (Exception ex)
            {
                MessageBox.Show("Опибка при входе: " + ex.Message);
            }
        }
        //закрытие программы
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //переключатель между формой авторизации и новая заявка на ремонт
        private void button2_Click_1(object sender, EventArgs e)
        {
            Заявка_на_ремон frm2 = new Заявка_на_ремон();
            frm2.Show();
            this.Hide();
        }
    }
    } 
















