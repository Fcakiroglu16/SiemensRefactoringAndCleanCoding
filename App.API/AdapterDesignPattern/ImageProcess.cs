namespace App.API.AdapterDesignPattern
{
    public class ImageProcess : IImageProcess
    {
        public void AddWatermark(string text, string fileName, Stream imageStream)
        {
            // add watermark
            Console.WriteLine($"{text} - {fileName}");
        }
    }
}