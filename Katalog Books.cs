using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
   
    public partial class Form1 : Form
    {
       
        
        
        string path = @"C:\Users\Руслан\Desktop\2 Задание.txt";
        public Form1()
        {
            InitializeComponent();
        }
        private void add1_Click(object sender, EventArgs e)
        {
            
            string s = str.Text.ToString();
            string r = rtg.Text;
            string ktgr = cb1.Text;
            string kg = tb1.Text;
            FileStream fs = new FileStream(path,FileMode.Append);
            fs.Close();
            StreamWriter sw = new StreamWriter(path,true);

            if (chb1.Checked == true)
            { sw.WriteLine("Категория книги: {0}, книга '{1}', статус: {2}", ktgr, kg, chb1.Text);
                sw.Close();
            }
            
            if (chb2.Checked == true)
            {
                sw.WriteLine("Категория книги: {0}, книга '{1}', статус: {2}, рейтинг: {3}", ktgr, kg, chb1.Text, r);
                sw.Close();
            }
            
            if (chb3.Checked == true)
            {
                sw.WriteLine("Категория книги: {0}, книга '{1}', статус: {2}, на какой странице остановились: {3}", ktgr, kg, chb1.Text,s);
                sw.Close();
            }
        }

        private void chb1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb1.Checked == true)
            {
                rtg.Visible = false;
                str.Visible = false;
                chb2.Checked = false;
                chb3.Checked = false;
            }
            else { rtg.Visible = true; str.Visible = true; }
        }
        private void chb2_CheckedChanged(object sender, EventArgs e)
        {
            if (chb2.Checked == true)
            {
                str.Visible = false;
                chb1.Checked = false;
                chb3.Checked = false;
            }
            else str.Visible = true;
        }
        private void chb3_CheckedChanged(object sender, EventArgs e)
        {
            if (chb3.Checked == true)
            {
                rtg.Visible = false;
                chb1.Checked = false;
                chb2.Checked = false;
            }
            else rtg.Visible = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string s = textbox1.Text;
            string[] st = File.ReadAllLines(path);
            if (textbox1.Text != "")
            {
                for (int i = 0; i < st.Length; i++)
                {
                    if (st[i].Contains(s))
                    {
                        listBox1.Items.Add(st[i]);
                    }
                }
            }
            if (textbox1.Text==""&& chb1.Checked)
            {
                for (int i = 0; i < st.Length; i++)
                {
                    if (st[i].Contains(chb1.Text))
                    {
                        listBox1.Items.Add(st[i]);
                    }
                }
            }
            if (textbox1.Text == "" && chb2.Checked)
            {
                for (int i = 0; i < st.Length; i++)
                {
                    if (st[i].Contains(chb2.Text))
                    {
                        listBox1.Items.Add(st[i]);
                    }
                }
            }
            if (textbox1.Text == "" && chb3.Checked)
            {
                for (int i = 0; i < st.Length; i++)
                {
                    if (st[i].Contains(chb3.Text))
                    {
                        listBox1.Items.Add(st[i]);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] st = File.ReadAllLines(path);
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i].Contains(rtg.Text) == st[i + 1].Contains(rtg.Text))
                {
                    listBox1.Items.Add();
                }
            }
        }
    }
} 
