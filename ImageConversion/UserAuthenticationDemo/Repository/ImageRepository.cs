namespace ImageConversion.Repository
{
    public class ImageRepository : IImageRepository
    {
        public string ImageUrl()
        {
            string path = @"C:\photo\Ujjwal.png";
            byte [] data = File.ReadAllBytes(path);
            return Convert.ToBase64String(data);
        }
    }
}
//Convert image into base64 and send into json