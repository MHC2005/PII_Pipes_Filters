using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {

        PictureProvider provider = new PictureProvider();
        IPicture picture = provider.GetPicture(@"luke.jpg");

        IFilter filter_grey = new FilterGreyscale(); 
        IFilter filter_negative = new FilterNegative();

        IPipe pipe1  = new PipeSerial(filter_grey,new PipeNull());
        IPipe pipe2  = new PipeSerial(filter_negative,new PipeNull());

        pipe1.Send(picture);
        IPicture image = pipe2.Send(picture);

        PictureProvider provider2 = new PictureProvider();
        provider.SavePicture(image, @"luke2.jpg");
        }
    }
}
