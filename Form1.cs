using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> Karakter = new List<string>();
            Karakter.Add("Mahzar");
            Karakter.Add("Ruhsar");
            Karakter.Add("Menkıbe");
            Karakter.Add("Müfit");
            Karakter.Add("Reyhan");
            Karakter.Add("Firdevs");
            foreach (string s in Karakter)
            {
                listBox1.Items.Add(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(22);
            sayilar.Add(34);
            sayilar.Add(65);
            sayilar.Add(51);
            sayilar.Add(67);
            sayilar.Add(13);
            sayilar.Add(67);
            sayilar.Add(28);
            foreach (int s in sayilar)
            {
                if (s % 2 == 0)
                    listBox2.Items.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<kisiler> kisi = new List<kisiler>();
            kisi.Add(new kisiler()
            {
                ADI="Ali",
                SOYADI="Çınar",
                MESLEKI="Öğretmen"
            });
            foreach (kisiler item in kisi)
            {
                listBox3.Items.Add(item.ADI+" "+item.SOYADI+" "+item.MESLEKI);
            }
        }
    }
}
