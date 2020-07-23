using NUnit.Framework;
using BlogApp;
using EFGetStarted;
using System.Collections.Generic;

namespace BlogTests
{
    public class Tests
    {
        private Blog _blog = new Blog();
        private Post _post = new Post();
        private BlogManager _blogManager = new BlogManager();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReadFromBlogClass()
        {
            List<Blog> result = new List<Blog>() { new Blog() { BlogId = 59, Url = "Hey" } };
    
            var actual = _blogManager.ReadBlog();
            Assert.AreEqual(result[0], actual[0]);
        }
    }
}