using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using Ucu.Poo.Twitter;

namespace CompAndDel.Filters
{
    public class Upload2Twitter : TwitterImage
    {
        public IPicture Filter(IPicture image)
        {
            return image;
        }

        public string UploadImageToTwitter(string text, string pathToImage)
        {
            var twitter = new TwitterImage();
            string result = twitter.PublishToTwitter(text, pathToImage);

            return result;
        }
    }
}