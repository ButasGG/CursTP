using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CursTP
{
    public class TP
    {
        // вводим наши переменные: координаты телеортов, радиус частиц
        public int X; 
        public int Y;
        public int Rad = 50; 
        public int OX; 
        public int OY; 
        public float OTP = 0; 
        public float OS = 5;

        public void ImpactParticle(PRTC particle) // "сердце" нашего телепорта (отправка партиклов)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); 
            if (r + particle.Rad < Rad / 2)
            {
                particle.X = OX + -gX;
                particle.Y = OY + -gY;

                particle.SX = (float)(Math.Cos(OTP / 180 * Math.PI) * OS);
                particle.SY = -(float)(Math.Sin(OTP / 180 * Math.PI) * OS);
            }
        }
        public void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Black),OX - Rad/ 2,OY - Rad / 2,Rad,Rad); // рисуем наш выходной телепорт
            g.FillEllipse(Brushes.Orange, OX - Rad / 2, OY - Rad / 2, Rad, Rad); // закрасим для визуального эффекта 1 телепорт 
            g.DrawEllipse(new Pen(Color.Black),X - Rad / 2,Y - Rad / 2,Rad,Rad); // рисуем наш входной телепорт 
            g.FillEllipse(Brushes.Blue, X - Rad / 2, Y - Rad / 2, Rad, Rad); // закрасим для визуального эффекта 2 телепорт 
        }
    }
}
