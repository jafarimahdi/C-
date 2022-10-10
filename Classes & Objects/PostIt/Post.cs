using System;
namespace PostIt
{
    public class Post
    {
        public string backgrandColor;
        public string text;
        public string textColor;

        public Post(string _backgrandColor, string _text, string _textColor)
        {
            backgrandColor = _backgrandColor;
            text = _text;
            textColor = _textColor;
        }

    }
}

