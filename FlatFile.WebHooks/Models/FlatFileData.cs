using System.Collections.Generic;

namespace FlatFileIO.NET.Models
{
    public class FlatFileData<T>
    {
        public Meta Meta { get; set; }
        public List<T> ValidRows { get; set; }
        public List<T> InvalidRows { get; set; }
    }
}