using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using Ucu.Poo.Twitter;
using Ucu.Poo.Cognitive;
using System.Drawing;

namespace CompAndDel;

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
        string text = "hijo de anakin";
        string pathToImage = @"luke2.jpg";
        Console.WriteLine(uploadTwitter.UploadImageToTwitter(text, pathToImage));
        */

        //ejercicio 4
        /*
        {
        CognitiveFace cog = new CognitiveFace(true, Color.GreenYellow); //no reconoce la cara porque no esta a color
        cog.Recognize(@"beer.jpg");
        FoundFace(cog);
        }

        void FoundFace(CognitiveFace cog)
        {
        if (cog.FaceFound)
        {
        Console.WriteLine("Face Found!");
        IFilter filter1 = new FilterGreyscale();
        IPipe pipe1 = new PipeSerial(filter1, new PipeNull());
        IPicture picture = provider.GetPicture(@"luke.jpg"); // Obtener la imagen nuevamente
        IPicture picture1 = pipe1.Send(picture);
        provider.SavePicture(picture1, @"HayCara.jpg");

        if (cog.GlassesFound)
        {
            Console.WriteLine("Tiene Lentes 🤓");
        }
        else
        {
            Console.WriteLine("No tiene lentes");
        }
        }
        else
            Console.WriteLine("No Hay Cara");
            IFilter filter2 = new FilterNegative();
            IPipe pipe2 = new PipeSerial(filter2, new PipeNull());
            IPicture picturea = provider.GetPicture(@"luke.jpg"); // Obtener la imagen nuevamente
            IPicture pictureb = pipe2.Send(picturea);
            provider.SavePicture(pictureb, @"NoTieneCara.jpg");
        }
            */
        }
    }
        


