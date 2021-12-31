using System;
using System.Collections.Generic;
using System.Text;

namespace Entites
{
    public class Tag
    {
        public string Title { get; set; }
        public virtual List<ItemTag> Item { get; set; }
    }
}
