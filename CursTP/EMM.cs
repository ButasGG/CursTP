using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CursTP
{
    public class EMM
    {
        public List<PRTC> prtc = new List<PRTC>();
        public TP tel = new TP();
        public float GX = 0;
        public float GY = 1;

        public int X; 
        public int Y; 
        public int TPP = 0;
        public int RAZ = 360; 
        public int SMIN = 1;
        public int SMAX = 10;
        public int RadMIN = 2;
        public int RadMAX = 10;
        public int LifeMIN = 20;
        public int LifeMAX = 50;
        public int VALUE1 = 1;
        public int VALUE2 = 10;

        public Color TP1 = Color.Blue;
        public Color TP2 = Color.FromArgb(0, Color.Purple);


        public void UpdateState()
        {
            int particlesToCreate = VALUE1;

            foreach (var particle in prtc)
            {
                if (particle.Life <= 0)
                {
                    if (particlesToCreate > 0)
                    {
                        particlesToCreate -= 1;
                        ResetParticle(particle);
                    }
                }
                else
                {
                    particle.Life -= 1;

                    particle.X += particle.SX;
                    particle.Y += particle.SY;

                    tel.ImpactParticle(particle);

                    particle.SX += GX;
                    particle.SY += GY;
                }
            }

            while (particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = Create();
                ResetParticle(particle);
                prtc.Add(particle);
            }
        }

        public virtual void ResetParticle(PRTC particle)
        {
            particle.Life = PRTC.rand.Next(LifeMIN, LifeMAX);

            particle.X = X;
            particle.Y = Y;

            var tp = TPP
                + (double)PRTC.rand.Next(RAZ)
                - RAZ / 2;

            var speed = PRTC.rand.Next(SMIN, SMAX);

            particle.SX = (float)(Math.Cos(tp / 180 * Math.PI) * speed);
            particle.SY = -(float)(Math.Sin(tp / 180 * Math.PI) * speed);

            particle.Rad = PRTC.rand.Next(RadMIN, RadMAX);
        }
        public virtual PRTC Create()
        {
            var particle = new ParticleColorful();
            particle.FTP = TP1;
            particle.TTP = TP2;

            return particle;
        }
        public void Render(Graphics g)
        {
            foreach (var particle in prtc)
            {
                particle.Draw(g);
            }

            tel.Render(g);
        }
    }
}
