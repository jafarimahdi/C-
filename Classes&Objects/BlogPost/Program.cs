﻿using System;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Reflection.Metadata;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a BlogPost class that has
            //    an authorName
            //    a title
            //    a text
            //    a publicationDate
            //Create a few blog post objects:
            //    "Lorem Ipsum" titled by John Doe posted at "2000.05.04."
            //        Lorem ipsum dolor sit amet.
            //    "Wait but why" titled by Tim Urban posted at "2010.10.10."
            //        A popular long-form, stick-figure-illustrated blog about almost everything.
            //    "One Engineer Is Trying to Get IBM to Reckon With Trump" titled by William Turton at "2017.03.28."
            //        Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention.When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.



            BlogPost loremIpsum = new BlogPost("John Doe", "Lorem Ipsum", "Loremipsum dolor sit amet", "2000.05.04");

            BlogPost mahdiIpsum = new BlogPost("Jafari mahdi", "Mahdi Ipsum", "Loremipsum dolor sit amet", "2022.10.28");


            BlogPost waitButWhy = new BlogPost("Tim Urban", "Wait but why", "a popular long-form, stick-figure-illustrated blog abuot almost everything", "2010.10.10");


            Blog firstPublish = new Blog();

            firstPublish.Add(loremIpsum);
            firstPublish.Add(waitButWhy);

            Console.WriteLine("------");

            firstPublish.Delete(0);
            //firstPublish.Delete(0);

            Console.WriteLine("------");

            firstPublish.Update(0, mahdiIpsum);
        }
    }
}

