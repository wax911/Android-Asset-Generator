using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Generator
{
    public class Converter
    {
        /// <summary> 
        /// A quick lookup for getting image encoders 
        /// </summary> 
        private Dictionary<string, ImageCodecInfo> encoders;

        /// <summary> 
        /// A quick lookup for getting image encoders 
        /// </summary> 
        public Dictionary<string, ImageCodecInfo> Encoders
        {
            //get accessor that creates the dictionary on demand 
            get
            {
                //if the quick lookup isn't initialised, initialise it 
                if (encoders == null)
                {
                    encoders = new Dictionary<string, ImageCodecInfo>();
                }
                
                //if there are no codecs, try loading them 
                if (encoders.Count != 0) return encoders;
                //get all the codecs 
                foreach (var codec in ImageCodecInfo.GetImageEncoders())
                {
                    //add each codec to the quick lookup 
                    encoders.Add(codec.MimeType.ToLower(), codec);
                }
                //return the lookup 
                return encoders;
            }
        }


        /// <summary> 
        /// Resize the image to the specified width and height. 
        /// </summary> 
        /// <param name="image">The image to resize.</param> 
        /// <param name="width">The width to resize to.</param> 
        /// <param name="height">The height to resize to.</param> 
        /// <returns>The resized image.</returns> 
        public Bitmap ResizeImage(Image image, Resolution dim)
        {
            //a holder for the result 
            var result = new Bitmap(dim.Width, dim.Height);

            //use a graphics object to draw the resized image into the bitmap 
            using (var graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality 
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the image into the target bitmap 
                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
            }
            //return the resulting bitmap 
            return result;
        }

        /// <summary>  
        /// Returns the image codec with the given mime type  
        /// </summary>  
        public ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            //do a case insensitive search for the mime type 
            string lookupKey = mimeType;
            //the codec to return, default to null 
            ImageCodecInfo foundCodec = null;
            //if we have the encoder, get it to return 
            if (Encoders.ContainsKey(lookupKey))
            {
                //pull the codec from the lookup 
                foundCodec = Encoders[lookupKey];
            }
            return foundCodec;
        }
    }
}
