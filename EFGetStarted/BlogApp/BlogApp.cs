using System;
using EFGetStarted;
using System.Linq;
using System.Collections.Generic;

namespace BlogApp
{
    public class BlogManager
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //Create
        public void Add(string userInput)
        {
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = $"{userInput}" });
                db.SaveChanges();
            }
        }

        //Read
        public string Read()
        {
            using (var db = new BloggingContext())
            {
                string blogList = "";
                Console.WriteLine("Querying for a blog");
                var blogs =
                    from blog in db.Blogs.OrderBy(b => b.BlogId)
                    select blog;
                //var blog = db.Blogs
                //    .OrderBy(b => b.BlogId)
                //    .First();
                foreach(var blog in blogs)
                {
                    blogList += $"{blog.Url}\n";
                }
                return blogList;
                
            }
        }

        //Delete
        public void Delete(string userInput)
        {
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Delete the blog");
                var blog = db.Blogs.First();
                //var blogs =
                //    from blog in db.Blogs.Where(b => b.Url.Equals($"{userInput}"))
                //    select blog;
                //string toDelete = blog.Url.Equals($"{userInput}").ToString();
                db.Remove(blog);
                db.SaveChanges();
            }
        }

        //Update
        public static void Update(string userInput, string title, string content)
        {
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Updating the blog and adding a post");
                var blog = db.Blogs.First();
                //var blogs =
                //    from blog in db.Blogs
                //    join post in db.Posts on blog.BlogId equals post.BlogId
                //    select blog;
                blog.Url = userInput;
                blog.Posts.Add(
                    new Post
                    {
                        Title = title,
                        Content = content
                    });
                db.SaveChanges();
            }
        }
    }
}
