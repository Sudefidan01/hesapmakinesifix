using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1 = 0, sayi2 = 0, sayac = 0,sonuc=0;
        string islem = string.Empty;
        private void button4_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Button btn= (Button)sender;
            btn.BackColor = Color.LightGray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayac = 0;
            islem = ((Button)sender).Text;

            if (lblSonuc.Text=="0")
            {
                lblSayi.Text = sayi1.ToString() + " " + islem;
            }
            else
            {
                sayi1=double.Parse(lblSonuc.Text);
                lblSayi.Text = sayi1.ToString() + " " + islem;
                
            }
        }
       
        private void Sil(object sender, EventArgs e)
        {
            if (lblSonuc.Text.Length>1)
            {
                lblSonuc.Text = lblSonuc.Text.Substring(0,lblSonuc.Text.Length - 1);
            }
            else
            {
                lblSonuc.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sayac = 0;
            sayi2 = double.Parse(lblSonuc.Text);

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;

            }
            lblSonuc.Text=sonuc.ToString();
            lblSayi.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonuc= 0;
            sayi1 = 0;
            sayi2= 0;
            islem = string.Empty;
            sayac = 0;
            lblSayi.Text=string.Empty;
            lblSonuc.Text = "0";

        }

        private void Hesapla(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            var basamak = lblSonuc.Text.Split(',');

            if (basamak.Length==1)
            {
                if (basamak[0].Length<17)
                {
                    Yazdir(sender);
                }
            }
            else
            {
                if (basamak[1].Length<6)
                {
                    Yazdir(sender);
                }
            }
            if (btn.Text==",")
            {
                if (!lblSonuc.Text.Contains(","))
                { 
                    if (lblSonuc.Text.Length == 0)
                    {
                        lblSonuc.Text = "0";
                    }
                    lblSonuc.Text += btn.Text;
                }
               
            }
        }
        public void Yazdir(object sender)
        {
            Button btn= (Button)sender;
            if (btn.Text != ",")
            {
                if (lblSayi.Text.Length > 0)
                {
                    if (sayac == 0)
                    {
                        lblSonuc.Text = string.Empty;
                    }
                    sayac++;
                    if (lblSonuc.Text.Length == 0)
                    {
                        lblSonuc.Text = "0";
                    }

                    if (btn.Text == "0")
                    {
                        if (!(lblSonuc.Text.Length == 1 && lblSonuc.Text == "0"))
                        {
                            lblSonuc.Text = btn.Text;
                        }
                    }
                    else
                    {
                        if (lblSonuc.Text.Length == 1 && lblSonuc.Text == "0")
                        {
                            lblSonuc.Text = string.Empty;
                        }
                        lblSonuc.Text += btn.Text;
                    }
                }
                else
                {
                    if (lblSonuc.Text.Length == 0)
                    {
                        lblSonuc.Text = "0";
                    }
                    if (btn.Text == "0")
                    {
                        if (!(lblSonuc.Text.Length == 1 && lblSonuc.Text == "0"))
                        {
                            lblSonuc.Text += btn.Text;
                        }
                    }
                    else
                    {
                        if (lblSonuc.Text.Length == 1 && lblSonuc.Text == "0")
                        {
                            lblSonuc.Text = string.Empty;
                        }
                        lblSonuc.Text += btn.Text;
                    }
                }
            }


        }
    }
}
