using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dadinho_CTI
{
    public partial class dado : Form
    {
        private Random sorteio = new Random();
        public dado()
        {
            InitializeComponent();
        }
        
        private void btnJogar_Click(object sender, EventArgs e)
        {
            int dado1;
            dado1 = sorteio.Next(1,7);
            string caminho= Directory.GetCurrentDirectory()  + "\\Imagens\\dado"+dado1 + ".jpg");
              //MessageBox.Show(dado1.ToString());
              // picDajog.Image = Image.FromFile(Directory.GetCurrentDirectory()
              //  + "\\Imagens\\dado"+dado1 + "*.jpg");
        }

        private void btnFoto1_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.Filter = "JPEG| *.jpg|PNG| *.png|Icone| *.ico ";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                picJog.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnAp_Click(object sender, EventArgs e)
        {
            picJog.Image = null;
        }

        private void btnFoto2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG| *.jpg|PNG| *.png|Icone| *.ico ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picJog2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                if (colorDialog1.Color.Name != "Black")
                {
                    this.BackColor=colorDialog1.Color;
                }
                
            }
               
        }

        private void btnAp2_Click(object sender, EventArgs e)
        {
            this.btnAp2.Click += new System.EventHandler(this.btnAp2_Click);

        }
    }
}
