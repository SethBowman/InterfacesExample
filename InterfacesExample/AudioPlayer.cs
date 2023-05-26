using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public class AudioPlayer : IMediaPlayer
    {
        public void Pause()
        {
            //Pause audio logic
            Console.WriteLine("Audio paused");
        }

        public void Play()
        {
            //Play audio logic
            Console.WriteLine("Audio playing..");
        }

        public void Stop()
        {
            //Stop audio logic
            Console.WriteLine("Audio stopped");
        }
    }
}
