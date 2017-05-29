using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectors
{
    public partial class Form1 : Form
    {
        bool Swap { get; set; } = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Calc()
        {
            

            StringBuilder res = new StringBuilder();
            res.Append(Swap ? "B with A" : "A with B");

            try
            {
                Vector3D A = new Vector3D(double.Parse(TxtAx.Text), double.Parse(TxtAy.Text), double.Parse(TxtAz.Text));
                Vector3D B = new Vector3D(double.Parse(TxtBx.Text), double.Parse(TxtBy.Text), double.Parse(TxtBz.Text));
                if (Swap)
                {
                    res.Append("\nB + A = ").Append(B + A);
                    res.Append("\nB - A = ").Append(B - A);
                    res.Append("\nB . A = ").Append(B * A);
                    res.Append("\nB x A = ").Append(B & A);
                }
                else
                {
                    res.Append("\nA + B = ").Append(A + B);
                    res.Append("\nA - B = ").Append(A - B);
                    res.Append("\nA . B = ").Append(A * B);
                    res.Append("\nA x B = ").Append(A & B);
                }
            }
            catch (FormatException)
            {
            }
            LblResult.Text = res.ToString();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Calc();
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            Swap = !Swap;
            Calc();
        }


    }
}
