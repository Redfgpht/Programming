using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2s_2.Model
{
    public class Song
    {
        private int duration;
        private string name;
        private string author;
        public Song(int duration, string name, string author)
        {
            setDuration(duration);
            setName(name);
            setAuthor(author);
        }

        public void setDuration(int duration)
        {
            if (duration > -1)
            {
                this.duration = duration;
            }
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAuthor(string author)
        {
            this.author = author;
        }
        public int getDuration()
        {
            return duration;
        }
        public string getName()
        {
            return name;
        }
        public string getAuthor()
        {
            return author;
        }
    }
}
