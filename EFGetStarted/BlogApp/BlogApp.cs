using System;
using EFGetStarted;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlogApp
{
    public class BlogManager
    {
        public Blog SelectedBlog { get; set; }
        public Post SelectedPost { get; set; }
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

        //Read Blog
        public List<Blog> ReadBlog()
        {
            using (var db = new BloggingContext())
            {
                var blog = db.Blogs.Include(p => p.Posts).ToList();
                return blog;
            }
        }

        public List<Post> ReadPost(int blogId)
        {
            using (var db = new BloggingContext())
            {
                var post = db.Posts.Where(b => b.BlogId == blogId).ToList();
                return post;
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

        public void DeletePost(int postId)
        {
            using (var db = new BloggingContext())
            {
                var post = db.Posts.Where(p => p.PostId == postId).FirstOrDefault();
                db.Posts.Remove(post);
                db.SaveChanges();
            }
        }

        //Update
        public void Update(string title, string content)
        {
            using (var db = new BloggingContext())
            {
                var blog = db.Blogs.Where(b => b.BlogId == SelectedBlog.BlogId).Include(p => p.Posts).FirstOrDefault();

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
                Blog blog = db.Blogs.Where(b => b.BlogId == SelectedBlog.BlogId).FirstOrDefault();
                blog.Url = url;
                db.SaveChanges();
            }
        }

        public void SetSelectedBlogs(object selectedItem)
        {
            SelectedBlog = (Blog)selectedItem;
        }

        public void SetSelectedPosts(object selectedItem)
        {
            SelectedPost = (Post)selectedItem;
        }
    }
}
