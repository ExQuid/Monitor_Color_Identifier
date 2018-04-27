using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TwoThree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            List<Color> colList = new List<Color>();



            for (int y = 0; y < Screen.PrimaryScreen.Bounds.Height; y += 10)
            {
                for (int x = 0; x < Screen.PrimaryScreen.Bounds.Width; x++)
                {
                    colList.Add(bitmap.GetPixel(x, y));
                    if (bitmap.GetPixel(x, y) == Color.FromArgb(255, 0, 0, 0))
                    {
                        Cursor.Position = new Point(x, y);
                        Console.WriteLine(Cursor.Position);
                        Thread.Sleep(100);
                        Found();
                    }

                }
            }
        }



        private void Found()
        {
            Console.WriteLine("You did it!");
        }

    }

}
