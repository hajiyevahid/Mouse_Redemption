using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOUSE_REDEMPTION
{
    public partial class fewf : Form
    {
        public fewf()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
             pictureBox12.Visible = false;
             pictureBox13.Visible = false;
             pictureBox14.Visible = false;
            pictureBox15.Visible = false;
         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
           pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;
            while (pictureBox3.Left-15 > pictureBox16.Left)
            {
                
                pictureBox3.Left-=1;
            }
            pictureBox3.Top -= 60;

            Random q = new Random();
            int a = q.Next(1, 5);
            textBox2.Text = a.ToString();

            if (a == 1)
            {
                pictureBox20.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            while (pictureBox3.Left-15 > pictureBox17.Left)
            {

                pictureBox3.Left -= 1;
            }
            pictureBox3.Top -= 60;


            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 2)
            {
                pictureBox21.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
            }

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            while (pictureBox3.Left  < pictureBox18.Left+10)
            {

                pictureBox3.Left += 1;
            }
            pictureBox3.Top -= 60;

            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 3)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox22.Visible = true;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
            }

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;
            while (pictureBox3.Left < pictureBox19.Left + 10)
            {

                pictureBox3.Left += 1;
            }
            pictureBox3.Top -= 60;

            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 4)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox23.Visible = true;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
            }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
             pictureBox12.Visible = false;
              pictureBox13.Visible = false;
             pictureBox14.Visible = false;
             pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(165, 155);

            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 1)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox24.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(250, 155);
            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 2)
            {
                textBox1.Visible = true;
                pictureBox25.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
            }

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(335, 155);
            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 3)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox26.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
            }
            pictureBox14.BackColor = Color.Red;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(425, 155);


            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 4)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox27.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(165, 105);
            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 1)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox28.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(255, 105);

           // pictureBox3.Location = new Point(165, 105);
            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 2)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox29.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(335, 105);
           // pictureBox3.Location = new Point(165, 105);
            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 3)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox30.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(425, 105);
          //  pictureBox3.Location = new Point(165, 105);
            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 4)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox31.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(170, 55);
            textBox1.Visible = true;
          //  pictureBox3.Location = new Point(165, 105);
            Random q = new Random();
            int a = q.Next(1, 5);

            if (a == 1||a==2)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox32.Visible = true;
               
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(255, 55);
            textBox1.Visible = true;
            Random q = new Random();
            int a = q.Next(1, 5);
            if (a == 1 || a == 2)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox33.Visible = true;

            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(340, 55);
            textBox1.Visible = true;

            Random q = new Random();
            int a = q.Next(1, 5);
            if (a == 3 || a == 4)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox34.Visible = true;

            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox19.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Location = new Point(430, 55);
            textBox1.Visible = true;

            Random q = new Random();
            int a = q.Next(1, 5);
            if (a == 3 || a == 4)
            {
                textBox1.Visible = true;
                textBox1.Text = " ! You Lose";
                pictureBox35.Visible = true;

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }
    }
}
