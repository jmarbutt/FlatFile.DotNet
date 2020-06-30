namespace FlatFileIO.NET.Models
{
    public class FlatFileRequest<T>
    {
        public FlatFileData<T> Data { get; set; }

        public FlatFileEvent Event { get; set; }

    }
}