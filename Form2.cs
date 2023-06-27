using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastryCook
{
    public partial class Form2 : Form
    {
        static void Log(string message)
        {
            string logmessage = $"{DateTime.Now} - {message}{Environment.NewLine}";
            File.AppendAllText(@"D:\сишарп\oil\log.txt", logmessage);
        }

        public Form2()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // нельзя изменить размер формы

            const string caption = "Attention!"; // messagebox
            string message = "Вы можете вписать один ключевой ингридиент или название десерта, а после произведётся поиск.";
            DialogResult open = MessageBox.Show(message, caption);

            medovik.URL = @"D:\сишарп\oil\Recources\medovik.mp4"; // добавление видео в проект
            napoleon.URL = @"D:\сишарп\oil\Recources\napoleon.mp4"; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fitirLink.Visible = false; // прячем все элементы
            fitir.Visible = false;
            esterhaziLink.Visible = false;
            esterhazi.Visible = false;
            flanLink.Visible = false;
            flan.Visible = false;
            woopeeLink.Visible = false;
            woopee.Visible = false;
            apLink.Visible = false;
            ap.Visible = false;
            convertikiLink.Visible = false;
            convertiki.Visible = false;
            ruletLink.Visible = false;
            rulet.Visible = false;
            medovik.Visible = false;
            medovikLabel.Visible = false;
            napoleon.Visible = false;
            napoleonLabel.Visible = false;
        }

        private void lineSearch_TextChanged(object sender, EventArgs e)
        {
            Regex milk = new Regex(@"\b(М|м)олоко|(Ф|ф)ытыр|(Э|э|Е|е)стерхази|(Ф|ф)лан|(В|в)у(п|пп)и|(Ш|ш)арлотка|(К|к)онвертики\b");
            Match milkMatch = milk.Match(lineSearch.Text);

            if (milkMatch.Success)
            {
                fitirLink.Visible = true;
                fitir.Visible = true;
                esterhaziLink.Visible = true;
                esterhazi.Visible = true;
                flanLink.Visible = true;
                flan.Visible = true;
                woopeeLink.Visible = true;
                woopee.Visible = true;
                apLink.Visible = true;
                ap.Visible = true;
                convertikiLink.Visible = true;
                convertiki.Visible = true;
                ruletLink.Visible = false;
                rulet.Visible = false;
                medovik.Visible = false;
                medovikLabel.Visible = false;
                napoleon.Visible = false;
                napoleonLabel.Visible = false;
            }

            Regex butter = new Regex(@"\b(М|м)асло|(Ф|ф)ытыр|(Э|э|Е|е)стерхази|(Р|р)улет|(В|в)у(п|пп)и|(Ш|ш)арлотка|(К|к)онвертики\b");
            Match butterMatch = butter.Match(lineSearch.Text);

            if (butterMatch.Success)
            {
                fitirLink.Visible = true;
                fitir.Visible = true;
                esterhaziLink.Visible = true;
                esterhazi.Visible = true;
                woopeeLink.Visible = true;
                woopee.Visible = true;
                apLink.Visible = true;
                ap.Visible = true;
                convertikiLink.Visible = true;
                convertiki.Visible = true;
                ruletLink.Visible = true;
                rulet.Visible = true;
                medovik.Visible = false;
                medovikLabel.Visible = false;
                napoleon.Visible = false;
                napoleonLabel.Visible = false;
            }

            Regex honey = new Regex(@"\b(В|в)идео|(Н|н)аполеон|(М|м)едовик\b");
            Match honeyMatch = honey.Match(lineSearch.Text);

            if (honeyMatch.Success)
            {
                medovik.Visible = true;
                medovikLabel.Visible = true;
                napoleon.Visible = true;
                napoleonLabel.Visible = true;
            }

                Log("Пользователь вводил запросы");
        }
        //
        // присвоение ссылок
        //
        private void fitirLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.russianfood.com/recipes/recipe.php?rid=136000");
        }
        private void esterhazi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.russianfood.com/recipes/recipe.php?rid=120857");
        }
        private void flanLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.russianfood.com/recipes/recipe.php?rid=159020");
        }
        private void woopeeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.russianfood.com/recipes/recipe.php?rid=132946");
        }
        private void apLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.russianfood.com/recipes/recipe.php?rid=164570");
        }
        private void convertikiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.russianfood.com/recipes/recipe.php?rid=118543&ref=cro_t_3&token=1124441400");
        }
        private void ruletLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.russianfood.com/recipes/recipe.php?rid=114987");
        }
    }
}
