using System;
using EFGetStarted;
using System.Linq;
using System.Collections.Generic;

namespace BlogApp
{
    public class BlogManager
    {
        public Blog SelectedBlog { get; set; }
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
        public List<Blog> Read()
        {
            using (var db = new BloggingContext())
            {
                List<Blog> blogList = new List<Blog>();
                Console.WriteLine("Querying for a blog");
                //var blogs =
                //   from blog in db.Blogs.OrderBy(b => b.BlogId)
                //   join post in db.Posts on blog.BlogId equals post.BlogId
                //   select blog;
                   //select new { blogUrl = blog.Url, postTitle = post.Title, postContent = post.Content };
                //var blog = db.Blogs
                //    .OrderBy(b => b.BlogId)
                //    .First();
                //foreach (var blog in blogs)
                //{
                //    blogList.Add(blog.Url).ToList();
                //}
                return db.Blogs.ToList();
                
            }
        }

        //Delete
        public void Delete()
        {
            using (var db = new BloggingContext())
            {
                db.Remove(SelectedBlog);
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

        public void Edit(string url)
        {
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Updating the blog and adding a post");
                var blog = db.Blogs.First();
                //var blogs =
                //    from blog in db.Blogs
                //    join post in db.Posts on blog.BlogId equals post.BlogId
                //    select blog;
                blog.Url = url;
                //blog.Posts.Add(
                //    new Post
                //    {
                //        Title = title,
                //        Content = content
                //    });
                db.SaveChanges();
            }
        }

        public void SetSelectedBlogs(object selectedItem)
        {
            SelectedBlog = (Blog)selectedItem;
        }
    }
}
