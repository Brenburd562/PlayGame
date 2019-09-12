using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //declartion of varables 
            Graphics g = this.CreateGraphics();
            SolidBrush blackbrush = new SolidBrush(Color.Black);
            SolidBrush whitebrush = new SolidBrush(Color.White);
            Font Arial = new Font("Arial", 37, FontStyle.Bold);
            
            //clearing screen for black background then drawing large white rectangle and smaller black rectangle inside it for border 
            g.Clear(Color.Black);
            g.FillRectangle(whitebrush, 250, 150, 300, 200);
            g.FillRectangle(drawBrush, 260, 160, 280, 180);
            
            //writing words to fit in box
            g.DrawString("Play Game", Arial, whitebrush, 270, 220);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //declare all ghraphics and audio vars
            Graphics g = this.CreateGraphics();
            SolidBrush whitebrush = new SolidBrush(Color.White);
            SolidBrush blackbrush = new SolidBrush(Color.Black);
            Font Arial = new Font("Arial", 25, FontStyle.Bold);
            SoundPlayer Dixie = new SoundPlayer(Properties.Resources.dixie_horn_daniel_simion);
            SoundPlayer Door = new SoundPlayer(Properties.Resources.Door_Bell_SoundBible_com_1986366504);
            SoundPlayer honk = new SoundPlayer(Properties.Resources.Horn_Honk_SoundBible_com_1634776698);
            SoundPlayer Metroid = new SoundPlayer(Properties.Resources.Metroid_Door_Brandino480_995195341);
            
            //clear background and start count down 
            g.Clear(Color.Black);
            Dixie.Play();
            Thread.Sleep(3000);
            //start with audio then display GAME START IN and number ready to change
            g.DrawString("GAME START IN:", Arial, whitebrush, 200, 220);
            g.DrawString("3", Arial, whitebrush, 480, 220);
            
            //delay each section by 1 seccond 
            Thread.Sleep(1000);
            Door.Play();

            //cover number in order for new number to take its place 
            g.FillRectangle(blackbrush, 480, 220, 40, 50);
            g.DrawString("2", Arial, whitebrush, 480, 220);

            //run same sequence but change effect
            Thread.Sleep(1000);
            honk.Play();
            g.FillRectangle(blackbrush, 480, 220, 40, 50);
            g.DrawString("1", Arial, whitebrush, 480, 220);

            //run same sequence but change effect
            Thread.Sleep(1000);
            g.Clear(Color.Beige);
            Metroid.Play();
            g.DrawString("GO GO GO!!!", Arial, blackbrush, 250, 220);
        }
    }
}
