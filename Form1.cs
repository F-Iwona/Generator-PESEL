using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            int year;
            int month;
            int day;
            int number;

            //próba zamiany podanych przez użytkownika wartości z text na int
            if (!int.TryParse(Year.Text, out number) || !int.TryParse(Month.Text, out number) || !int.TryParse(Day.Text, out number))
            {
                Answer.Text = "Nieprawidłowa data urodzenia.";
            }
            else {
                year = int.Parse(Year.Text);
                month = int.Parse(Month.Text);
                day = int.Parse(Day.Text);

                if (isValid(year, month, day))
                {
                    for (int i = 1; i <= int.Parse(comboBox1.Text); i++)
                    {
                        if(i % 2 == 1 && i != 1)
                        {
                            text = text + "\r\n";
                            text = text + GeneratePesel(year, month, day)+"          ";
                        }
                        else
                        {
                            text = text + GeneratePesel(year, month, day)+ "          ";
                        }
                    }
                    Answer.Text = text;
                }
                else
                {
                    Answer.Text = "Nieprawidłowa data urodzenia.";
                }
            }
            
        }

        //funkcja sprawdzająca czy podany rok jest przestępny
        bool LeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //funkcja sprawdzająca poprawność podanego roku, miesiąca i dnia urodzenia
        bool isValid(int year, int month, int day)
        {
            if (year >= 1800 && year <= 2299 && month >= 1 && month <= 12)
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (day >= 1 && day <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day >= 1 && day <= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (LeapYear(year))
                    {
                        if (day >= 1 && day <= 29)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (day >= 1 && day <= 28)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        //funkcja generująca pesel
        string GeneratePesel(int year, int month, int day)
        {
            int[] peselArray = new int[11];
            peselArray[0] = (year % 100) / 10;
            peselArray[1] = (year % 100) % 10;

            if (year >= 1800 && year <= 1899)
            {
                month = month + 80;
                peselArray[2] = month / 10;
                peselArray[3] = month % 10;
            }
            else if (year >= 1900 && year <= 1999)
            {
                peselArray[2] = month / 10;
                peselArray[3] = month % 10;
            }
            else if (year >= 2000 && year <= 2099)
            {
                month = month + 20;
                peselArray[2] = month / 10;
                peselArray[3] = month % 10;
            }
            else if (year >= 2100 && year <= 2199)
            {
                month = month + 40;
                peselArray[2] = month / 10;
                peselArray[3] = month % 10;
            }
            else if (year >= 2200 && year <= 2299)
            {
                month = month + 60;
                peselArray[2] = month / 10;
                peselArray[3] = month % 10;
            }

            peselArray[4] = day / 10;
            peselArray[5] = day % 10;

            for (int i = 6; i < 9; i++)
            {
                peselArray[i] = rnd.Next(0, 10);
            }

            if (Kobieta.Checked)
            {
                peselArray[9] = rnd.Next(0, 5) * 2;
            }
            else
            {
                peselArray[9] = rnd.Next(0, 5) * 2 + 1;
            }

            int checkSum = 0;
            int[] weight = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            for (int i = 0; i < 10; i++)
            {
                checkSum += peselArray[i] * weight[i];
            }
            peselArray[10] = (10 - (checkSum % 10)) % 10;

            string pesel = string.Join("", peselArray);
            return pesel;
        }
    }
}
