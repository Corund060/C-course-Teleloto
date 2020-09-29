using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200618_Teleloto
{
    public partial class Teleloto : Form
    {
        public Teleloto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            Bilietas bilt = new Bilietas();
            bilt.M = new List<int>();
            bilt.J = new List<int>();
            bilt.R = new List<int>();
            bilt.G = new List<int>();
            bilt.Z = new List<int>();
            int a = 0;
            for (int i = 0; i <= 4; i++)
            {
                a = rnd.Next(1, 16);                
                while (bilt.M.Contains(a)==true)
                {
                    a= rnd.Next(1, 16);
                }
                bilt.M.Add(a);

                a = rnd.Next(16, 31);
                while (bilt.J.Contains(a) == true)
                {
                    a = rnd.Next(16, 31);
                }
                bilt.J.Add(a);

                a = rnd.Next(31, 46);
                while (bilt.R.Contains(a) == true)
                {
                    a = rnd.Next(31, 46);
                }
                bilt.R.Add(a);

                a = rnd.Next(46, 61);
                while (bilt.G.Contains(a) == true)
                {
                    a = rnd.Next(46, 61);
                }
                bilt.G.Add(a);

                a = rnd.Next(61, 76);
                while (bilt.Z.Contains(a) == true)
                {
                    a = rnd.Next(61, 76);
                }
                bilt.Z.Add(a);
            }
            M1.Text = bilt.M[0].ToString();
            M2.Text = bilt.M[1].ToString();
            M3.Text = bilt.M[2].ToString();
            M4.Text = bilt.M[3].ToString();
            M5.Text = bilt.M[4].ToString();

            J1.Text = bilt.J[0].ToString();
            J2.Text = bilt.J[1].ToString();
            J3.Text = bilt.J[2].ToString();
            J4.Text = bilt.J[3].ToString();
            J5.Text = bilt.J[4].ToString();

            R1.Text = bilt.R[0].ToString();
            R2.Text = bilt.R[1].ToString();
            R3.Text = bilt.R[2].ToString();
            R4.Text = bilt.R[3].ToString();
            R5.Text = bilt.R[4].ToString();

            G1.Text = bilt.G[0].ToString();
            G2.Text = bilt.G[1].ToString();
            G3.Text = bilt.G[2].ToString();
            G4.Text = bilt.G[3].ToString();
            G5.Text = bilt.G[4].ToString();

            Z1.Text = bilt.Z[0].ToString();
            Z2.Text = bilt.Z[1].ToString();
            Z3.Text = bilt.Z[2].ToString();
            Z4.Text = bilt.Z[3].ToString();
            Z5.Text = bilt.Z[4].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int c = 1; c < 50000; c++)
            {


                
                for (int i = 1; i <= 38; i++)
                {
                    var rnd = new Random();
                    Bilietas bilt = new Bilietas();
                    bilt.M = new List<int>();
                    bilt.J = new List<int>();
                    bilt.R = new List<int>();
                    bilt.G = new List<int>();
                    bilt.Z = new List<int>();
                    int a = 0;
                    int spalva = rnd.Next(0, 5);
                    label2.Text = "Nr.:" + i.ToString();
                    switch (spalva)
                    {
                        case 0:
                            a = rnd.Next(1, 16);
                            while (bilt.M.Contains(a))
                            {
                                a = rnd.Next(1, 16);
                            }
                            Kamuol.ForeColor = System.Drawing.Color.Blue;
                            Kamuol.Text = "M" + a.ToString();
                            bilt.M.Add(a);
                            break;
                        case 1:
                            a = rnd.Next(16, 31);
                            while (bilt.J.Contains(a))
                            {
                                a = rnd.Next(16, 31);
                            }
                            Kamuol.ForeColor = System.Drawing.Color.Black;
                            Kamuol.Text = "J" + a.ToString();
                            bilt.J.Add(a);
                            break;
                        case 2:
                            a = rnd.Next(31, 46);
                            while (bilt.R.Contains(a))
                            {
                                a = rnd.Next(31, 46);
                            }
                            Kamuol.ForeColor = System.Drawing.Color.Red;
                            Kamuol.Text = "R" + a.ToString();
                            bilt.R.Add(a);
                            break;
                        case 3:
                            a = rnd.Next(46, 61);
                            while (bilt.G.Contains(a))
                            {
                                a = rnd.Next(46, 61);
                            }
                            Kamuol.ForeColor = System.Drawing.Color.Yellow;
                            Kamuol.Text = "G" + a.ToString();
                            bilt.G.Add(a);
                            break;
                        case 4:
                            a = rnd.Next(61, 76);
                            while (bilt.Z.Contains(a))
                            {
                                a = rnd.Next(61, 76);
                            }
                            Kamuol.ForeColor = System.Drawing.Color.Green;
                            Kamuol.Text = "Z" + a.ToString();
                            bilt.Z.Add(a);
                            break;
                    }
                    bilt = null;
                    CheckToUzbraukti(spalva, a.ToString());
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(50);
                }
                Zaidimu.Text = c.ToString();
                Application.DoEvents();
                if (M1.BackColor==System.Drawing.Color.Pink & M5.BackColor == System.Drawing.Color.Pink & Z1.BackColor == System.Drawing.Color.Pink & M1.BackColor == System.Drawing.Color.Pink)
                {
                    if (J2.BackColor == System.Drawing.Color.Pink & J4.BackColor == System.Drawing.Color.Pink & G2.BackColor == System.Drawing.Color.Pink & G4.BackColor == System.Drawing.Color.Pink & R3.BackColor == System.Drawing.Color.Pink)
                    {
                        Istrizaines.Text = (Convert.ToInt32(Istrizaines.Text) + 1).ToString();
                    }
                    Kampai.Text = (Convert.ToInt32(Kampai.Text) + 1).ToString();
                    float tik =  100*((float) Convert.ToInt32(Kampai.Text) / Convert.ToInt32(Zaidimu.Text));
                    KampProc.Text = tik.ToString("0.00") + "%";

                    tik = 100*((float) Convert.ToInt32(Istrizaines.Text) / Convert.ToInt32(Zaidimu.Text));
                    IstrProc.Text = tik.ToString("0.00")+"%";
                }
                M1.BackColor = System.Drawing.Color.DarkGray;
                M2.BackColor = System.Drawing.Color.DarkGray;
                M3.BackColor = System.Drawing.Color.DarkGray;
                M4.BackColor = System.Drawing.Color.DarkGray;
                M5.BackColor = System.Drawing.Color.DarkGray;
                J1.BackColor = System.Drawing.Color.DarkGray;
                J2.BackColor = System.Drawing.Color.DarkGray;
                J3.BackColor = System.Drawing.Color.DarkGray;
                J4.BackColor = System.Drawing.Color.DarkGray;
                J5.BackColor = System.Drawing.Color.DarkGray;
                R1.BackColor = System.Drawing.Color.DarkGray;
                R2.BackColor = System.Drawing.Color.DarkGray;
                R3.BackColor = System.Drawing.Color.DarkGray;
                R4.BackColor = System.Drawing.Color.DarkGray;
                R5.BackColor = System.Drawing.Color.DarkGray;
                G1.BackColor = System.Drawing.Color.DarkGray;
                G2.BackColor = System.Drawing.Color.DarkGray;
                G3.BackColor = System.Drawing.Color.DarkGray;
                G4.BackColor = System.Drawing.Color.DarkGray;
                G5.BackColor = System.Drawing.Color.DarkGray;
                Z1.BackColor = System.Drawing.Color.DarkGray;
                Z2.BackColor = System.Drawing.Color.DarkGray;
                Z3.BackColor = System.Drawing.Color.DarkGray;
                Z4.BackColor = System.Drawing.Color.DarkGray;
                Z5.BackColor = System.Drawing.Color.DarkGray;
                Application.DoEvents();
            }
        }

        private void CheckToUzbraukti(int spalva, string text)
        {
            switch (spalva)
            {
                case 0:
                    if (M1.Text == text) M1.BackColor = System.Drawing.Color.Pink;
                    if (M2.Text == text) M2.BackColor = System.Drawing.Color.Pink;
                    if (M3.Text == text) M3.BackColor = System.Drawing.Color.Pink;
                    if (M4.Text == text) M4.BackColor = System.Drawing.Color.Pink;
                    if (M5.Text == text) M5.BackColor = System.Drawing.Color.Pink;
                    break;
                case 1:
                    if (J1.Text == text) J1.BackColor = System.Drawing.Color.Pink;
                    if (J2.Text == text) J2.BackColor = System.Drawing.Color.Pink;
                    if (J3.Text == text) J3.BackColor = System.Drawing.Color.Pink;
                    if (J4.Text == text) J4.BackColor = System.Drawing.Color.Pink;
                    if (J5.Text == text) J5.BackColor = System.Drawing.Color.Pink;
                    break;
                case 2:
                    if (R1.Text == text) R1.BackColor = System.Drawing.Color.Pink;
                    if (R2.Text == text) R2.BackColor = System.Drawing.Color.Pink;
                    if (R3.Text == text) R3.BackColor = System.Drawing.Color.Pink;
                    if (R4.Text == text) R4.BackColor = System.Drawing.Color.Pink;
                    if (R5.Text == text) R5.BackColor = System.Drawing.Color.Pink;
                    break;
                case 3:
                    if (G1.Text == text) G1.BackColor = System.Drawing.Color.Pink;
                    if (G2.Text == text) G2.BackColor = System.Drawing.Color.Pink;
                    if (G3.Text == text) G3.BackColor = System.Drawing.Color.Pink;
                    if (G4.Text == text) G4.BackColor = System.Drawing.Color.Pink;
                    if (G5.Text == text) G5.BackColor = System.Drawing.Color.Pink;
                    break;
                case 4:
                    if (Z1.Text == text) Z1.BackColor = System.Drawing.Color.Pink;
                    if (Z2.Text == text) Z2.BackColor = System.Drawing.Color.Pink;
                    if (Z3.Text == text) Z3.BackColor = System.Drawing.Color.Pink;
                    if (Z4.Text == text) Z4.BackColor = System.Drawing.Color.Pink;
                    if (Z5.Text == text) Z5.BackColor = System.Drawing.Color.Pink;
                    break;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    class Bilietas
    {
        public List<int> M { get; set; }
        public List<int> J { get; set; }
        public List<int> R { get; set; }
        public List<int> G { get; set; }
        public List<int> Z { get; set; }
    }
}
