using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalsRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kopeksolauzaklik, tavsansolauzaklik, atsolauzaklik;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int kopekgenislik = pictureBox1.Width;
            int tavsangenislik = pictureBox2.Width;
            int atgenislik = pictureBox3.Width;
            int bitisuzakligi = label5.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 16);
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Köpek Yarışı Önde Götürüyor";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Tavşan Öne Geçti";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "At İyi Bir Atakla Öne Geçti ";
            }
            if (kopekgenislik + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "***Köpek Kazandı***";

            }
            if (tavsangenislik + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "***Tavşan Kazandı***";

            }
            if (atgenislik + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "***At Kazandı***";

            }
        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            kopeksolauzaklik = pictureBox1.Left;
            tavsansolauzaklik = pictureBox2.Left;
            atsolauzaklik = pictureBox3.Left;
        }
    }
}
