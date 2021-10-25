using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MB_At_Yarışı_Oyunu_v1._0
{
    public partial class Form1 : Form
    {
        #region Metodlar

        #endregion

        #region Tanımlamalar

        Random r = new Random();

        #endregion

        #region Değişkenler

        int sol1, sol2, sol3, sol4; // Atların soldan uzaklığı.

        int u1, u2, u3, u4; // Atların toplam ilermesini sağlıcak uzaklık.

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;
        }

        int finish;
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sol1 = pictureBox1.Left;
            sol2 = pictureBox2.Left;
            sol3 = pictureBox3.Left;
            sol4 = pictureBox4.Left;

            u1 = pictureBox1.Width;
            u2 = pictureBox2.Width;
            u3 = pictureBox3.Width;
            u4 = pictureBox4.Width;

            finish = label2.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + r.Next(5,15); 
            pictureBox2.Left = pictureBox2.Left + r.Next(5, 15); 
            pictureBox3.Left = pictureBox3.Left + r.Next(5, 15); 
            pictureBox4.Left = pictureBox4.Left + r.Next(5, 15); 

            if (u1+pictureBox1.Left>=finish)
            {
                timer1.Stop();
                MessageBox.Show("1 Numaralı Albaturay yarışı kazandı.","Sonuç");
            }
                
            else if (u2 + pictureBox2.Left >= finish)
            {
                timer1.Stop();
                MessageBox.Show("2 Numaralı Huysuz yarışı kazandı.", "Sonuç");
            }

             else if (u3 + pictureBox3.Left >= finish)
            {
                timer1.Stop();
                MessageBox.Show("3 Numaralı Nazlıgelin yarışı kazandı.", "Sonuç");
            }

             else if (u4 + pictureBox4.Left >= finish)
            {
                timer1.Stop();
                MessageBox.Show("4 Numaralı Quick Shot yarışı kazandı.", "Sonuç");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
