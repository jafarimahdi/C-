using System;
namespace BlogPost
{
    public class Blog
    {
        string authorName;
        string title;
        string text;
        string publishDate;

        public Blog(string _authorName, string _title, string _text, string _publishDate)
        {
            authorName = _authorName;
            title = _title;
            text = _text;
            publishDate = _publishDate;
        }

    }
}

