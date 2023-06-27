﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace PastryCook
{
    public partial class Form1 : Form
     {
        //
        // объединение элементов
        // 
        List<Label> MussLabel = new List<Label>(); 
        List<PictureBox> MussPicture = new List<PictureBox>();

        List<Label> CustardLabel = new List<Label>(); 
        List<PictureBox> CustardPicture = new List<PictureBox>();

        List<Label> MeringLabel = new List<Label>();
        List<PictureBox> MeringPicture = new List<PictureBox>();

        List<Label> FlourLabel = new List<Label>();
        List<PictureBox> FlourPicture = new List<PictureBox>();
        //
        // логирование
        //
        static void Log(string message)
        {
            string logmessage = $"{DateTime.Now} - {message}{Environment.NewLine}";
            File.AppendAllText(@"D:\сишарп\PastryCook\log.txt", logmessage);
        }

        public Form1()
        {

            InitializeComponent();
            //
            // добавление элементов в лист и скрытие с приветственного окна
            //
            MussLabel.Add(MussIng); // мусс
            MussLabel.Add(MussIng2);
            MussLabel.Add(MussRec);
            MussLabel.Add(MussRec2);
            foreach (var v in MussLabel)
            {
                v.Visible = false;
            }
            MussPicture.Add(MussCakePic);
            MussPicture.Add(MussCakePic2);
            foreach (var v in MussPicture)
            {
                v.Visible = false;
            }

            CustardLabel.Add(CustardIng); // заварные
            CustardLabel.Add(CustardIng2);
            CustardLabel.Add(CustardRec);
            CustardLabel.Add(CustardRec2);
            foreach (var v in CustardLabel) 
            {
                v.Visible = false;
            }
            CustardPicture.Add(CustardCakePic);
            CustardPicture.Add(CustardCakePic2);
            foreach (var v in CustardPicture)
            {
                v.Visible = false;
            }

            MeringLabel.Add(MeringRec); // меренга
            MeringLabel.Add(MeringIng);
            foreach (var v in MeringLabel)
            {
                v.Visible = false;
            }
            MeringPicture.Add(MeringCakePic);
            MeringPicture.Add(MeringCakePic2);
            foreach (var v in MeringPicture)
            {
                v.Visible = false;
            }

            FlourLabel.Add(FlourIng); // мучные
            FlourLabel.Add(FlourIng2);
            FlourLabel.Add(FlourRec);
            FlourLabel.Add(FlourRec2);
            foreach (var v in FlourLabel)
            {
                v.Visible = false;
            }
            FlourPicture.Add(FlourCakePic);
            FlourPicture.Add(FlourCakePic2);
            foreach (var v in FlourPicture)
            {
                v.Visible = false;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // подсказки при наводке
            ToolTip HintAI = new ToolTip(); 
            HintAI.SetToolTip(addInfo, "насадки и красители");

            ToolTip HintAR = new ToolTip();
            HintAR.SetToolTip(AddRecipe, "добавить свой рецепт");

            ToolTip HintS = new ToolTip();
            HintAR.SetToolTip(searchButton, "поиск рецептов");
        }

        private void addInfo_Click(object sender, EventArgs e)
        {
                // подсветка
                addInfo.FlatStyle = FlatStyle.Flat; 
                addInfo.FlatAppearance.BorderColor = Color.DarkViolet;

                // вызов второй формы
                FormAI fai = new FormAI();
                fai.Show();

            Log("Пользователь просмотрел дополнительную информацию");
        }
        //
        // обработчики нажатий
        //
        private void MussCake_Click(object sender, EventArgs e)
        {
                begin.Visible = false;
                beginn.Visible = false;
                foreach (var v in MussLabel)
                {
                    v.Visible = true;
                }
                foreach (var v in MussPicture)
                {
                    v.Visible = true;
                }

                foreach (var v in CustardLabel)
                {
                    v.Visible = false;
                }
                foreach (var v in CustardPicture)
                {
                    v.Visible = false;
                }

                foreach (var v in MeringLabel)
                {
                    v.Visible = false;
                }
                foreach (var v in MeringPicture)
                {
                    v.Visible = false;
                }

                foreach (var v in FlourLabel)
                {
                  v.Visible = false;
                }
                foreach (var v in FlourPicture)
                {
                   v.Visible = false;
                }

            Log("Пользователь просмотрел рецепт муссовых изделий");
        }

        private void CustardCake_Click(object sender, EventArgs e)
        {
            begin.Visible = false;
            beginn.Visible = false;
            foreach (var v in MussLabel)
            {
                v.Visible = false;
            }
            foreach (var v in MussPicture)
            {
                v.Visible = false;
            }

            foreach (var v in CustardLabel)
            {
                v.Visible = true;
            }
            foreach (var v in CustardPicture)
            {
                v.Visible = true;
            }

            foreach (var v in MeringLabel)
            {
                v.Visible = false;
            }
            foreach (var v in MeringPicture)
            {
                v.Visible = false;
            }

            foreach (var v in FlourLabel)
            {
                v.Visible = false;
            }
            foreach (var v in FlourPicture)
            {
                v.Visible = false;
            }

            Log("Пользователь просмотрел рецепт заварных изделий");
        }

        private void MeringCake_Click(object sender, EventArgs e)
        {
            begin.Visible = false;
            beginn.Visible = false;
            foreach (var v in MussLabel)
            {
                v.Visible = false;
            }
            foreach (var v in MussPicture)
            {
                v.Visible = false;
            }

            foreach (var v in CustardLabel)
            {
                v.Visible = false;
            }
            foreach (var v in CustardPicture)
            {
                v.Visible = false;
            }

            foreach (var v in MeringLabel)
            {
                v.Visible = true;
            }
            foreach (var v in MeringPicture)
            {
                v.Visible = true;
            }

            foreach (var v in FlourLabel)
            {
                v.Visible = false;
            }
            foreach (var v in FlourPicture)
            {
                v.Visible = false;
            }

            Log("Пользователь просмотрел рецепт меренговых изделий");
        }

        private void FlourCake_Click(object sender, EventArgs e)
        {
            begin.Visible = false;
            beginn.Visible = false;
            foreach (var v in MussLabel)
            {
                v.Visible = false;
            }
            foreach (var v in MussPicture)
            {
                v.Visible = false;
            }

            foreach (var v in CustardLabel)
            {
                v.Visible = false;
            }
            foreach (var v in CustardPicture)
            {
                v.Visible = false;
            }

            foreach (var v in MeringLabel)
            {
                v.Visible = false;
            }
            foreach (var v in MeringPicture)
            {
                v.Visible = false;
            }

            foreach (var v in FlourLabel)
            {
                v.Visible = true;
            }
            foreach (var v in FlourPicture)
            {
                v.Visible = true;
            }

            Log("Пользователь просмотрел рецепт мучных изделий");
        }

        private void AddRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                const string way = @"D:\сишарп\PastryCook\resipesSave.txt";
                const string caption = "Message!";
                // если нет изменений
                string message = "Файл закрыт"; 
                DateTime lastdate = File.GetLastWriteTime(way);
                Process exe = Process.Start("notepad.exe", way);
                exe.WaitForExit();
                exe.Close();
                DateTime date = File.GetLastWriteTime(way);
                // если есть
                if (date != lastdate)
                {
                    message = "Файл был изменен";
                }
                DialogResult result = MessageBox.Show(message, caption);
            }
            catch (Exception an)
            {
                Console.WriteLine(an.Message);
            }

            Log("Пользователь добавил свой рецепт");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // вызов окна поисков рецептов
            Form2 search = new Form2();
            search.Show();

            Log("Пользователь использовал поиск");
        }
    }
    //
    //отладочный класс
    //
    public class Debugger
    {
        public static void StartDebug()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Debug.WriteLine("Отладка началась в " + DateTime.Now);
            Debugger.Break();
        }

        private static void Break()
        {
            throw new NotImplementedException();
        }

        public static void EndDebug()
        {
            Debug.WriteLine("Отладка закончена в " + DateTime.Now);
        }
    }
}

