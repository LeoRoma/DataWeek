using System;
using System.Collections.Generic;
using System.Text;

namespace EFGetStarted
{
    public partial class Blog
    {
        public override string ToString()
        {
            return $"{BlogId}: {Url}";
        }
    }

    public partial class Post
    {
        public override string ToString()
        {
            return $"{Title}: {Content}";
        }
    }
}
