using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PictureBox[,] bilder = new PictureBox[5,5];

            int bredd = 56, höjd = 56;

            for (int i = 0; i < 5;  i ++)
            {
                for(int z = 0; z < 5; z++)
                {
                    bilder[i,z] = new PictureBox();
                    bilder[i, z].Location = new Point(i * bredd + 50, z * höjd + 50);
                    bilder[i,z].Width = bredd;
                    bilder[i,z].Height = höjd;
                    bilder[i,z].BackgroundImage = Image.FromFile("Blomma-56.png");
                    bilder[i,z].Click += pbxBlomma_Click;

                    this.Controls.Add(bilder[i,z]);
                }
                

            }
        }


        private void pbxBlomma_Click(object sender, EventArgs e)
        {
            PictureBox klickadBlomma = (PictureBox)sender;
            klickadBlomma.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
