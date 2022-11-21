using System;
namespace BlogPost
{
    public class BlogPost
    {
        public string authorName;
        string title;
        string text;
        string publishDate;

        public BlogPost(string _authorName, string _title, string _text, string _publishDate)
        {
            authorName = _authorName;
            title = _title;
            text = _text;
            publishDate = _publishDate;
        }

    }
}

