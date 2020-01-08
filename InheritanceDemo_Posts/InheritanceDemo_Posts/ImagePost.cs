using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo_Posts
{
    //ImagePost class inherits from Posts class
    class ImagePost:Posts
    {
        //property
        protected string ImageURL { get; set; }

        //default constructor
        public ImagePost() { }

        //instant. constructor
        public ImagePost(string title, string sendByUsername, string imgURL, bool isPublic)
        {
            //inherited properties and method form Posts class
            this.ID = NextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
            //ImagePost class' own method
            this.ImageURL = imgURL;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.ImageURL,this.SendByUsername);
        }
    }
}
