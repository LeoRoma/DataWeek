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
            List<Blog> result = new List<Blog>() { new Blog() { BlogId = 68, Url = "Hola" } };
    
            var actual = _blogManager.ReadBlog();
            Assert.AreEqual(result[0].BlogId, 68);
            Assert.AreEqual(result[0].Url, "Hola");
        }

        [Test]
        public void AddABlog()
        {
            // arrange
            var count = _blogManager.ReadBlog().Count;
            // act
            _blogManager.Add("Hello");
            // assert
            var newCount = _blogManager.ReadBlog().Count;
            Assert.AreEqual(count + 1, newCount);
            // restore
            //*blogManager.Delete("Hello");  */       
        }
    }
}