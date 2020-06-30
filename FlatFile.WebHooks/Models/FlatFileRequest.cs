namespace FlatFile.WebHooks.Models
{
    public class FlatFileRequest<T>
    {
        public FlatFileData<T> Data { get; set; }

        public FlatFileEvent Event { get; set; }

    }
}