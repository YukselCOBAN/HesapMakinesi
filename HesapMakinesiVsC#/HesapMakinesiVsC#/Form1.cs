using System;
using System.Windows.Forms;

namespace HesapMakinesiVsC_
{
    public partial class Form1 : Form
    {
        int ekranSayisiIlk = 0;  //ekranda yazılan ilk sayı(+,- vs.ye basılmadan oncekini tutacagımız degısken)
        int ekranSayisiSon = 0;
        bool ekranTemizle = false;
        char secim;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ekranTemizle true ise;
            {
                ekranTemizle = false;
                labelekran.Text = "";
            }
            if (labelekran.Text == "0")
            {
                labelekran.Text = "";
            }
            labelekran.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ekranTemizle true ise;
            {
                ekranTemizle = false;
                labelekran.Text = "";
            }
            if (labelekran.Text == "0")
            {
                labelekran.Text = "";
            }
            labelekran.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ekranTemizle true ise;
            {
                ekranTemizle = false;
                labelekran.Text = "";
            }
            if (labelekran.Text == "0")
            {
                labelekran.Text = "";
            }
            labelekran.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ekranTemizle true ise;
            {
                ekranTemizle = false;
                labelekran.Text = "";
            }
            if (labelekran.Text == "0")
            {
                labelekran.Text = "";
            }
            labelekran.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ekranTemizle true ise;
            {
                ekranTemizle = false;
                labelekran.Text = "";
            }
            if (labelekran.Text == "0")
            {
                labelekran.Text = "";
            }
            labelekran.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ekranTemizle true ise;
            {
                ekranTemizle = false;
                labelekran.Text = "";
            }
            if (labelekran.Text == "0")
            {
                labelekran.Text = "";
            }
            labelekran.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ekranTemizle true ise;
            {
                ekranTemizle = false;
                labelekran.Text = "";
            }
            if (labelekran.Text == "0")
            {
                labelekran.Text = "";
            }
            labelekran.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ekranTemizle true ise;
            {
                ekranTemizle = false;
                labelekran.Text = "";
            }
            if (labelekran.Text == "0")
            {
                labelekran.Text = "";
            }
            labelekran.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ekranTemizle true ise;
            {
                ekranTemizle = false;
                labelekran.Text = "";
            }
            if (labelekran.Text == "0")
            {
                labelekran.Text = "";
            }
            labelekran.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ekranTemizle true ise;
            {
                ekranTemizle = false;
                labelekran.Text = "";
            }
            if (labelekran.Text == "0")
            {
                labelekran.Text = "";
            }
            labelekran.Text += "0";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            labelekran.Text = "";  //Text'i temizlendi label'in.
        }

        private void btnarti_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = int.Parse(labelekran.Text);
            ekranTemizle = true;
            secim = '+';

        }

        private void btnesit_Click(object sender, EventArgs e)
        {
            ekranSayisiSon = int.Parse(labelekran.Text);
            ekranTemizle = true;
            int sonuc = 0;

            switch (secim)
            {
                case '+': sonuc = ekranSayisiIlk + ekranSayisiSon; break;
                case '-': sonuc = ekranSayisiIlk - ekranSayisiSon; break;
                case 'x': sonuc = ekranSayisiIlk * ekranSayisiSon; break;
                case '/': sonuc = ekranSayisiIlk / ekranSayisiSon; break;

            }

            labelekran.Text = sonuc.ToString();
            ekranTemizle = true;

        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = int.Parse(labelekran.Text);
            ekranTemizle = true;
            secim = '-';
        }

        private void btncarpi_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = int.Parse(labelekran.Text);
            ekranTemizle = true;
            secim = 'x';

        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            ekranSayisiIlk = int.Parse(labelekran.Text);
            ekranTemizle = true;
            secim = '/';

        }


    }
}
