﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Proje_Sayısal_Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1, s2, s3,s4;
        private void button1_Click(object sender, EventArgs e)
        {
                Random rast = new Random();
                s1 = rast.Next(1,5);
                s2 = rast.Next(1,5);
                s3 = rast.Next(1,5);
                s4= rast.Next(1,5);

            label1.Text=s1.ToString();
            label2.Text=s2.ToString();
            label3.Text=s3.ToString();  
            label4.Text=s4.ToString();

            //sayı1
            if (textBox1.Text==label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            //sayı2
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            //sayı3
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            //sayı4
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            if (textBox1.BackColor==Color.Green && textBox2.BackColor == Color.Green && textBox3.BackColor == Color.Green && textBox4.BackColor == Color.Green)
            {
                MessageBox.Show("Büyük Ödülü Kazandınız","KAZANDINIZ");
            }

        }
    }
}
