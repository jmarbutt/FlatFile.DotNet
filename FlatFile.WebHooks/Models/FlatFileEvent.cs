namespace FlatFileIO.NET.Models
{
    public class FlatFileEvent
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public Sequence Sequence { get; set; }
    }
}