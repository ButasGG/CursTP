using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CursTP
{
    public class PRTC
    {
        // вводим наши переменные: радиус, координаты 1 и 2 телепорта, жизни частиц и генератор случайных чисел
        public int Rad; 
        public float X;
        public float Y;
        public float SX;
        public float SY;
        public float Life;
        public static Random rand = new Random();

        public PRTC()
        {
            var tp = (double)rand.Next(360);
            var speed = rand.Next(1, 10);
            SX = (float)(Math.Cos(tp / 180 * Math.PI) * speed);
            SY = -(float)(Math.Sin(tp / 180 * Math.PI) * speed);
            Rad = 2 + rand.Next(10);
            Life = 20 + rand.Next(100);
        }

        public virtual void Draw(Graphics g)
        {
            float f = Math.Min(1f, Life / 100);
            int alpha = (int)(f * 255);
            var color = Color.FromArgb(alpha, Color.Black);
            var b = new SolidBrush(color);
            g.FillEllipse(b, X - Rad, Y - Rad, Rad * 2, Rad * 2);
            b.Dispose();
        }
    }

    public class ParticleColorful : PRTC
    {
        public Color FTP;
        public Color TTP;

        public static Color Mix(Color color1, Color color2, float f)
        {
            return Color.FromArgb((int)(color2.A * f + color1.A * (1 - f)),(int)(color2.R * f + color1.R * (1 - f)),(int)(color2.G * f + color1.G * (1 - f)),(int)(color2.B * f + color1.B * (1 - f)));
        }

        public override void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);

            var color = Mix(TTP, FTP, k);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - Rad, Y - Rad, Rad * 2, Rad * 2);

            b.Dispose();
        }
    }
}
