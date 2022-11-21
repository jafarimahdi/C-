using System;
using System.Collections.Generic;

namespace BlogPost
{
    public class Blog
    {
        public List<BlogPost> blogList { get; set; }

        public Blog()
        {
            blogList = new List<BlogPost>();
        }

        public void Add(BlogPost newItem)
        {
            blogList.Add(newItem);

            foreach (BlogPost item in blogList)
            {
                Console.WriteLine(item.authorName);
            }
        }


        public void Delete(int itemToDelete)
        {
            blogList.RemoveAt(itemToDelete);

            foreach (BlogPost item in blogList)
            {
                Console.WriteLine(item.authorName);
            }

        }


        public void Update(int itemIndex, BlogPost newItemToAdd)
        {
            blogList.RemoveAt(itemIndex);
            blogList.Insert(itemIndex, newItemToAdd);

            foreach (BlogPost item in blogList)
            {
                Console.WriteLine(item.authorName);
            }
        }
    }
}

