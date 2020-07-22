using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace EFGetStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new BloggingContext())
            //{
            //    // Create
            //    Console.WriteLine("Inserting a new blog");
            //    db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            //    db.SaveChanges();

            //    // Read
            //    Console.WriteLine("Querying for a blog");
            //    var blog = db.Blogs
            //        .OrderBy(b => b.BlogId)
            //        .First();

            //    // Update
            //    Console.WriteLine("Updating the blog and adding a post");
            //    blog.Url = "https://devblogs.microsoft.com/dotnet";
            //    blog.Posts.Add(
            //        new Post
            //        {
            //            Title = "Hello World",
            //            Content = "I wrote an app using EF Core!"
            //        });
            //    db.SaveChanges();

            //    // Delete
            //    Console.WriteLine("Delete the blog");
            //    db.Remove(blog);
            //    db.SaveChanges();
            //}

            //Add("http://h1.com");
            //Add("http://h2.com");
            //Add("http://h3.com");
            Read();
            //Update("http://h1.com");
            Delete();

        }
        //Create
        public static void Add(string userInput)
        {
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = $"{userInput}" });
                db.SaveChanges();
            }
        }
        //Read
        public static void Read()
        {
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Querying for a blog");
                var blogs =
                    from blog in db.Blogs.OrderBy(b => b.BlogId)
                    select blog;
                //var blog = db.Blogs
                //    .OrderBy(b => b.BlogId)
                //    .First();
                foreach(var blog in blogs)
                {
                    Console.WriteLine($"{blog.Url}");
                }
                
            }
        }

        //Update
        public static void Update(string userInput)
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
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                db.SaveChanges();
            }
        }

        //Delete
        public static void Delete()
        {
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Delete the blog");
                //var blog = db.Blogs.First();
                var blogs =
                    from blog in db.Blogs
                    select blog;
                foreach(var b in blogs)
                {
                    db.Remove(b);
                }
                //db.Remove(blog);
                db.SaveChanges();
            }
        }
    }
}
