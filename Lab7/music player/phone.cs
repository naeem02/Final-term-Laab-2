using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{

    class Phone : Music, MusicInterface, RadioInterface

    {
        public void Switch(bool on)
            { switch (on)
            {
                case true:
                    Console.WriteLine("switch is on");
                    break;

                case false:
                    Console.WriteLine("switch is off");
                    break;


            }
            
                                      
                   }

       public void play(bool on)
        {
            switch(on)
            {
                case true:
                    Console.WriteLine("playing music");
                    break;
                case false:
                    Console.WriteLine("not playing music");
                    break;

            }

        }
       public void setVolume(int loudness)
        {
            int l = loudness;
            Console.WriteLine("Volume is set to:" + l);

        }
        public void playNext()
        {
            Console.WriteLine("playing Next song");
        }
        public void playPrevious()
        {
            Console.WriteLine("playing prevoius song");
        }
        public void retune(double frequency)
        {
            double f = frequency;
            Console.WriteLine("Frequency retune done to :"+f);
        }
       public void changeChannel()
        {
            Console.WriteLine("changing the channel");
        }
       public void SetVolume(int loudness)
        {
            int ld = loudness;
        }

        public Phone()
        {
         
        }
        public void Music(string title, string artist, int yearOfRelease, int durationInSeconds) 
        {
            string t1 = title;
            string ar = artist;
            int yor = yearOfRelease;
            int dr = durationInSeconds;

          
            Console.WriteLine("Title name  : " + t1 );
            Console.WriteLine("Artist : " + ar);
            Console.WriteLine("THe year of release is  : " + yor );
            Console.WriteLine("Music Duration in seconds  : " + dr);
        }
    }
}