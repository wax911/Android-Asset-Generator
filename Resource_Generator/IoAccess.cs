using System;
using System.Drawing;
using System.Drawing.Imaging;
using Generator;
using System.IO;

namespace Resource_Generator
{
    class IoAccess
    {
        #region Readonly Fields
        private static readonly string path = @"C:\Android Resource Generator";
        private static readonly string[] dirs = { "drawable-hdpi", "drawable-mdpi", "drawable-xhdpi", "drawable-xxhdpi", "drawable-xxxhdpi" };
        private static readonly string splitter = @"\";
        private static readonly Converter converter = new Converter();
        #endregion

        private void Check(string path)
        {
            var dirInfo = new DirectoryInfo(path);
            if(dirInfo.Exists)
                return;
            dirInfo.Create();
        }

        /// <summary>  
        /// Saves an image as a jpeg image, with the given quality  
        /// </summary>  
        /// <param name="path">Path to which the image would be saved.</param>  
        /// <param name="quality">An integer from 0 to 100, with 100 being the  
        /// highest quality</param>  
        /// <exception cref="ArgumentOutOfRangeException"> 
        /// An invalid value was entered for image quality. 
        /// </exception> 
        public void SavePNG(Image[] images, int quality, string workspace)
        {
            //ensure the quality is within the correct range 
            if ((quality < 0) || (quality > 100))
            {
                //create the error message 
                string error = string.Format("Jpeg image quality must be between 0 and 100, with 100 being the highest quality.  A value of {0} was specified.", quality);
                //throw a helpful exception 
                throw new ArgumentOutOfRangeException(error);
            }

            //create an encoder parameter for the image quality 
            var qualityParam = new EncoderParameter(Encoder.Quality, quality);

            //get the jpeg codec 
            ImageCodecInfo jpegCodec = converter.GetEncoderInfo("image/png");

            //create a collection of all parameters that we will pass to the encoder 
            var encoderParams = new EncoderParameters(1);
            //set the quality parameter for the codec 
            encoderParams.Param[0] = qualityParam;
            //save the images using the codec and the parameters 
            //each image will be saved into it's folder
            for (int i = 0; i < images.Length; i++)
            {
                for (int j = 0; j < dirs.Length; j++)
                {
                    string desination = (path + splitter + workspace + dirs[i]);
                    Check(desination);
                    images[i].Save(desination, jpegCodec, encoderParams);
                }
                
            }
        }

        public void SavePNG(Image image, int quality, string workspace, int index, string name)
        {
            
            //ensure the quality is within the correct range 
            if ((quality < 0) || (quality > 100))
            {
                //create the error message 
                string error = string.Format("png image quality must be between 0 and 100, with 100 being the highest quality.  A value of {0} was specified.", quality);
                //throw a helpful exception 
                throw new ArgumentOutOfRangeException(error);
            }

            //create an encoder parameter for the image quality 
            var qualityParam = new EncoderParameter(Encoder.Quality, quality);

            //get the jpeg codec 
            ImageCodecInfo jpegCodec = converter.GetEncoderInfo("image/png");

            //create a collection of all parameters that we will pass to the encoder 
            var encoderParams = new EncoderParameters(1);
            //set the quality parameter for the codec 
            encoderParams.Param[0] = qualityParam;
            //save the images using the codec and the parameters 
            //each image will be saved into it's folder
           
            string desination = (path + splitter + workspace + splitter + dirs[index]);
            Check(desination);

            //using memory stream to avoid GDI+ exception from being thrown
            using (var stream = new MemoryStream())
            {
                image.Save(stream, jpegCodec, encoderParams);
                using (var result = Image.FromStream(stream))
                {
                    result.Save((desination + splitter + name));
                }
            }
        }
    }
}
