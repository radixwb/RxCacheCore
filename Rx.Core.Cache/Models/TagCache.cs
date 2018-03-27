using System;

namespace Rx.Core.Cache.Models
{
    public class TagCache
    {
        public Type Controller { get; set; }

        public string Etag { get; set; }
    }
}
