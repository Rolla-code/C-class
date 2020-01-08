using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo_Posts
{
    class Posts
    {
        private static int currentPostID;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //Default Constructor
        public Posts()
        {
            ID = 0;
            Title = "First post";
            SendByUsername = "John Doe";
            IsPublic = true;
        }

        //instantiated constructor
        public Posts(string title, bool isPublic, string sendByUsername)
        {
            this.ID = NextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
        }

        protected int NextId()
        {
            return ++currentPostID;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
