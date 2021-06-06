using System;

namespace Pictionary
{
    public class Image : IImage
    {
        public int [][] image;
        public Image(int [][] image)
        {
            this.image = image;
        }

        public void UpdateImage(IImage image1)
        {
            this.image = ((Image)image1).image;
        }
    }
}