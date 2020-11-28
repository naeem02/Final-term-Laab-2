using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Music
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private int durationInSeconds;

        public string name1
        {
            get { return title; }
            set { title = value; }
        }
        public string name2
        {
            get { return artist; }
            set { artist = value; }
        }
        public Music()
        {
          
        }
        public Music(string title, string artist,int yearOfRelease,int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }
        public void changeTitle(string title)
        {
            string t1 = title;
            Console.WriteLine("Changing the title :" + t1);
        }
    }
}