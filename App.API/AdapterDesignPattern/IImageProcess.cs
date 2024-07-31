namespace App.API.AdapterDesignPattern
{
    public interface IImageProcess
    {
        void AddWatermark(string text, string fileName, Stream imageStream);
    }
}