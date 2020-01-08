using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InheritanceDemo_Posts
{
    class VideoPost:Posts
    {
        //member fields
        protected bool playing = false;
        protected int curDuration = 0;
        Timer timer;

        //properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }
        public VideoPost()
        {

        }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            //Inherited properties from Posts class
            this.ID = NextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            //VideoPost's property
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!playing) {
                playing = true;
            Console.WriteLine("Video is playing");
            timer = new Timer(TimerCallback,null,0,2000);
            }
        }

        private void TimerCallback(Object obj)
        {
            if(curDuration < Length)
            {
                curDuration++;
                Console.WriteLine("Video is at {0}s",curDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (playing) {
                playing = false;
            Console.WriteLine("Video was stopped at {0}s", curDuration);
            curDuration = 0;
            timer.Dispose();//reset timer
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}s", this.ID, 
                this.Title, this.VideoURL, this.Length, this.SendByUsername );
        }

    }
}
