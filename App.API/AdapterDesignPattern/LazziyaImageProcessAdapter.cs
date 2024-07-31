using System.Drawing;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.AdapterDesignPattern
{
    public class LazziyaImageProcessAdapter() : IImageProcess
    {
        public void AddWatermark(string text, string fileName, Stream imageStream)
        {
            Console.WriteLine($"Lazziya Image Process {text} - {fileName}");

            //using (var img = Image.FromStream(imageStream))
            //{
            //    var tOps = new TextWatermarkOptions
            //    {
            //        // Change text color and opacity
            //        // Text opacity range depends on Color's alpha channel (0 - 255)
            //        TextColor = Color.FromArgb(50, Color.White),

            //        // Add text outline
            //        // Outline color opacity range depends on Color's alpha channel (0 - 255)
            //        OutlineColor = Color.FromArgb(255, Color.Black)
            //    };

            //    img.AddTextWatermark(text, tOps)
            //        .SaveAs(fileName);
            //}
        }
    }
}