using System;
using System.Collections.Generic;
using System.Text;

namespace Entites
{
    public class ShortArticle
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileUrl { get; set; }
        public virtual List<ItemTag> Tags { get; set; }
    }
}
