using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate("https://www.bing.com/translator?to=tr&setlang=tr");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = textBox1.Text;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (label1.Text == "Türkçe")
                {
                    label1.Text = "İngilizce";
                    label2.Text = "Türkçe";
                }
                else if (label1.Text == "İngilizce")
                {
                    label1.Text = "Türkçe";
                    label2.Text = "İngilizce";
                }
                webBrowser1.Document.GetElementById("tta_revIcon").InvokeMember("click");
                textBox2.Clear();
                textBox1.Clear();
            }
            catch
            { }
        }
        int say = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (say == 3) timer1.Stop();
                //textBox2.Text = webBrowser1.Document.GetElementById("tta_output_ta").InnerText;
                //textBox3.Focus();
                say++;
                //Çevirilen Kelimeyi TextBox2 ye Getir
            }
            catch
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                webBrowser1.Document.GetElementById("tta_playicontgt").InvokeMember("click");
                //Girilen Kelimeyi Oku
            }
            catch
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("tta_playicontgt").InvokeMember("click");
                //Çevirilen Kelimeyi Oku
            }
            catch
            { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Enabled=true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                //Sesi yazıya dönüştürme işlemi
                webBrowser1.Document.GetElementsByTagName("b_icon tooltip");

                textBox3.Text = webBrowser1.Document.GetElementById("tta_input_ta").InnerText;
                int a = 0;

                if (a == 10)
                {
                    webBrowser1.Document.GetElementsByTagName("b_close");
                    timer2.Enabled = false;
                }
                
            }
            catch
            {
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
