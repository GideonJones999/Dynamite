using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamite
{
    public partial class Form1 : Form
    {
        //GLOBAL VARS
        DynArray<PictureBox> pics = new DynArray<PictureBox>();
        List<PictureBox> MrWhite = new List<PictureBox>();

        int x = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Creating PictureBox temp
            PictureBox temp = new PictureBox();
            temp.Size = new Size(80, 80);
            temp.Location = new Point(x, 100);
            temp.BackgroundImageLayout = ImageLayout.Stretch;
            temp.BackgroundImage = Properties.Resources.PictureBox;
            Controls.Add(temp);

            pics.Add(temp);

            //Draw Next PictureBox 50 Pixles to the Right
            //Start Again
            x = x > 1000 ? x = -100 : x + 50;

            //Move PictureBox Down
            for (int i = 0; i < pics.Count; i++)
                pics.getMember(i).Top += 10;

            //Udpdate Display
            picCount.Text = "COUNT = " + pics.Count;
            picCapacity.Text = "CAPACITY = " + pics.Capacity;
        }
    }
}
