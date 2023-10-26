using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using Ucu.Poo.Twitter;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
        //ejercicio 1
        /*
        PictureProvider provider = new PictureProvider();
        IPicture picture = provider.GetPicture(@"luke.jpg");

        IFilter filter_grey = new FilterGreyscale(); 
        IFilter filter_negative = new FilterNegative();

        IPipe pipe1  = new PipeSerial(filter_grey,new PipeNull());
        IPipe pipe2  = new PipeSerial(filter_negative,pipe1);

        // Aplicar los filtros
        pipe1.Send(picture);
        IPicture image = pipe2.Send(picture);

        // Guardar la imagen filtrada
        PictureProvider provider2 = new PictureProvider();
        provider.SavePicture(image, @"luke2.jpg");
        */
        
        //ejercicio2    
        /*
        PictureProvider provider = new PictureProvider();
        IPicture picture = provider.GetPicture(@"luke.jpg");

        IFilter filter_grey = new FilterGreyscale();
        IFilter filter_negative = new FilterNegative();

        IPipe pipe1 = new PipeSerial(filter_grey, new PipeNull());
        IPipe pipe2 = new PipeSerial(filter_negative, new PipeNull());

        // Aplicar los filtros
        IPicture filteredImage = pipe1.Send(picture);
        IPicture filteredImage2 = pipe2.Send(picture);

        // Guardar la imagen filtrada
        provider.SavePicture(filteredImage, @"luke_grises.jpg");
        provider.SavePicture(filteredImage2, @"luke_negative.jpg");
        */
        
        //ejercicio 3
        /*
        var uploadTwitter = new Upload2Twitter();
        string text = "Luke el capo";
        string pathToImage = @"lukeEditado2.jpg";
        Console.WriteLine(uploadTwitter.UploadImageToTwitter(text, pathToImage));
        */

        //ejercicio 4
        
        }
    }
}


