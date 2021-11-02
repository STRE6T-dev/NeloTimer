using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace NeloTimer
{
    public partial class frmNeloFoceser : Form
    {
        System.Timers.Timer tDeath,tAim,tStudy,tBreak;
        String chooice;
        Boolean deathClick = false;
        Boolean aimClick = false;
        Boolean studyClick = false;
        Boolean breakClick = false;
        int h, m, s;
        public frmNeloFoceser()
        {
           
            InitializeComponent();
            
        }

        private void btDeathMatch_Click(object sender, EventArgs e)
        {
            deathClick = true;
            aimClick = false;
            tAim.Stop();
            studyClick = false;
            tStudy.Stop();
            breakClick = false;
            tBreak.Stop();

            h = 0;
            m = 0;
            s = 0;
            chooice = btnDeathMatch.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            tDeath.Start();
            if (h == 1)
            {

                tDeath.Stop();
            }
        }

        private void btAimLabs_Click(object sender, EventArgs e)
        {
            aimClick = true;
            deathClick = false;
            tDeath.Stop();
            studyClick = false;
            tStudy.Stop();
            breakClick = false;
            tBreak.Stop();

            h = 0;
            m = 0;
            s = 0;
            chooice = "btnAimLab";
            tAim.Start();
            if(h ==  1)
            {
                tAim.Stop();
            }
        }

        private void btStudy_Click(object sender, EventArgs e)
        {

            studyClick = true;
            breakClick = false;
            tBreak.Stop();
            deathClick = false;
            tDeath.Stop();
            aimClick = false;
            tAim.Stop();

            h = 0;
            m = 0;
            s = 0;
            chooice = "btnStudy";
            tStudy.Start();
            if (h == 1)
            {
                tStudy.Stop();
            }

        }

        private void btBreak_Click(object sender, EventArgs e)
        {
            breakClick = true;
            studyClick = false;
            tStudy.Stop();
            deathClick = false;
            tDeath.Stop();
            aimClick = false;
            tAim.Stop();
            h = 0;
            m = 0;
            s = 0;
            


            chooice = "btnBreak.Text";
            tBreak.AutoReset = true;
            tBreak.Start();
            if ( s == 10)
            {
                tBreak.Stop();
            }
        }

        private void frmNeloFoceser_Load(object sender, EventArgs e)
        {
            int timeInterval = 1000;
            tDeath = new System.Timers.Timer();
            tDeath.Interval = timeInterval;
            tDeath.Elapsed += OnTimeEventDeath;

            tAim = new System.Timers.Timer();
            tAim.Interval = timeInterval;
            tAim.Elapsed += OnTimeEventAim;

            tStudy = new System.Timers.Timer();
            tStudy.Interval = timeInterval;
            tStudy.Elapsed += OnTimeEventStudy;

            tBreak = new System.Timers.Timer();
            tBreak.Interval = timeInterval;
            tBreak.Elapsed += OnTimeEventBreak;

        }

        private void OnTimeEventDeath(object sender, ElapsedEventArgs e)
        {
            StopSimpleSound();
            Invoke(new Action(() =>
            {
                s += 1;
                if(s== 60)
                {
                    s = 0;
                    m  += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                if (h == 1)
                {
                    playSimpleSound();
                    deathClick = false;
                }

                if(deathClick == true)
                {
                    btnDeathMatch.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                }
              
                
                
                
                
            }));
           

        }

        //Aim event timer
        private void OnTimeEventAim(object sender, ElapsedEventArgs e)
        {
            StopSimpleSound();
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                if (h == 1)
                {
                    aimClick = false;
                    playSimpleSound();
                }

              
                if (aimClick == true)
                {
                    btnAimLab.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

                }
              



            }));


        }
        // Study event timer
        private void OnTimeEventStudy(object sender, ElapsedEventArgs e)
        {
            StopSimpleSound();
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                if (h == 1)
                {
                    studyClick = false;
                    playSimpleSound();
                }

              
                if (studyClick == true)
                {
                    btnStudy.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                }
               



            }));


        }
        //Break event timer
        private void OnTimeEventBreak(object sender, ElapsedEventArgs e)
        {
            StopSimpleSound();

            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                if (m == 11)
                {
                    tAim.Stop();
                    breakClick = false;
                    playSimpleSound();

                }
                if (breakClick == true)
                {
                    btnBreak.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

                }




            }));
        }//End of method

        private static void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\STRE6T\Music\Black.wav");
            simpleSound.Play();
        }//end of method

        private static void StopSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\STRE6T\Music\Black.wav");
            simpleSound.Stop();
           
        }//end of method
    }
}
