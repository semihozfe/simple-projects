using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;

        }
        int soruno = 0 , doğru=0 , yanlış = 0;

        private void buttona_Click(object sender, EventArgs e)
        {
            buttonsonraki.Enabled = true;
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            labelcevap.Text = buttona.Text;
            if (labelcevap.Text == labeldoğrucevap.Text) 
            {
                doğru++;
                labeldoğrusayısı.Text = doğru.ToString();
                labeldoğru.Visible = true;
                buttona.BackColor = Color.Green;
            }
            else
            {
                yanlış++;
                labelyanlışsayısı.Text = yanlış.ToString();
                labelyanlış.Visible = true;
                buttona.BackColor = Color.Red;


            }
        }

        private void buttonb_Click(object sender, EventArgs e)
        {
            buttonsonraki.Enabled = true;
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false; 
            labelcevap.Text = buttonb.Text;
            if (labelcevap.Text == labeldoğrucevap.Text)
            {
                doğru++;
                labeldoğrusayısı.Text = doğru.ToString();
                labeldoğru.Visible = true;
                buttonb.BackColor = Color.Green;

            }
            else
            {
                yanlış++;
                labelyanlışsayısı.Text = yanlış.ToString();
                labelyanlış.Visible = true;
                buttonb.BackColor = Color.Red;

            }
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            buttonsonraki.Enabled = true;
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            labelcevap.Text = buttonc.Text;
            if (labelcevap.Text == labeldoğrucevap.Text)
            {
                doğru++;
                labeldoğrusayısı.Text = doğru.ToString();
                labeldoğru.Visible = true;
                buttonc.BackColor = Color.Green;

            }
            else
            {
                yanlış++;
                labelyanlışsayısı.Text = yanlış.ToString();
                labelyanlış.Visible = true;
                buttonc.BackColor = Color.Red;

            }
        }

        private void buttond_Click(object sender, EventArgs e)
        {
            buttonsonraki.Enabled = true;
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            labelcevap.Text = buttond.Text;
            if (labelcevap.Text == labeldoğrucevap.Text)
            {
                doğru++;
                labeldoğrusayısı.Text = doğru.ToString();
                labeldoğru.Visible = true;
                buttond.BackColor = Color.Green;
            }
            else
            {
                yanlış++;
                labelyanlışsayısı.Text = yanlış.ToString();
                labelyanlış.Visible = true;
                buttond.BackColor = Color.Red;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttona.BackColor = Color.Gray;
            buttonb.BackColor = Color.Gray;
            buttonc.BackColor = Color.Gray;
            buttond.BackColor = Color.Gray;

            buttona.Enabled = true;
            buttonb.Enabled = true;
            buttonc.Enabled = true;
            buttond.Enabled = true;
            buttonsonraki.Enabled = false;
            labeldoğru.Visible = false;
            labelyanlış.Visible = false;
            soruno++;
            labelsorusayısı.Text = soruno.ToString(); 
            if (soruno == 1) 
            {
                richTextBox1.Text = "Türkiyenin başkenti neresidir ?";
                buttona.Text = "Samsun";
                buttonb.Text = "İstanbul";
                buttonc.Text = "İzmir";
                buttond.Text = "Ankara";
                labeldoğrucevap.Text = "Ankara";
            }else if (soruno == 2) 
            {
                richTextBox1.Text = "Samsun'un plakası nedir ?";
                buttona.Text = "53";
                buttonb.Text = "55";
                buttonc.Text = "52";
                buttond.Text = "54";
                labeldoğrucevap.Text = "55";
            }else if(soruno == 3) 
            {
                richTextBox1.Text = "Samsun'un nüfusu kaçtır ?";
                buttona.Text = "1.3 M";
                buttonb.Text = "1.4 M";
                buttonc.Text = "1.5 M";
                buttond.Text = "1.6 M";
                labeldoğrucevap.Text = "1.3 M";
                buttonsonraki.Text = "Sonuçlar";
              
            }
            if (soruno == 4)
            {
                buttona.Enabled = false;
                buttonb.Enabled = false;
                buttonc.Enabled = false;
                buttond.Enabled = false;
               richTextBox1.Text=("Doğru = " + labeldoğrusayısı.Text + "\n " + "Yanlış = " + labelyanlışsayısı.Text);
                buttonsonraki.Enabled = false;
            }

        }
    }
}
