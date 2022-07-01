using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using EasyTabs;

namespace Replacord_Gateway
{
    public partial class AppContainer : TitleBarTabs
    {


        public AppContainer()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);

        }

        private static int MoreBrightnessIfNeeded(int defaultint, int add, int limit) => defaultint + add > limit ? defaultint : defaultint + add;


        private static bool IsBright(Color c) { return (int)Math.Sqrt(c.R * c.R * .241 + c.G * c.G * .691 + c.B * c.B * .068) > 130 ? true : false; }


        public static Image ColorReplace(Image inputImage, int tolerance, Color oldColor, Color NewColor)
        {
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);
            Graphics G = Graphics.FromImage(outputImage);
            G.DrawImage(inputImage, 0, 0);
            for (Int32 y = 0; y < outputImage.Height; y++)
                for (Int32 x = 0; x < outputImage.Width; x++)
                {
                    Color PixelColor = outputImage.GetPixel(x, y);
                    if (PixelColor.R > oldColor.R - tolerance && PixelColor.R < oldColor.R + tolerance && PixelColor.G > oldColor.G - tolerance && PixelColor.G < oldColor.G + tolerance && PixelColor.B > oldColor.B - tolerance && PixelColor.B < oldColor.B + tolerance)
                    {
                        int RColorDiff = oldColor.R - PixelColor.R;
                        int GColorDiff = oldColor.G - PixelColor.G;
                        int BColorDiff = oldColor.B - PixelColor.B;

                        if (PixelColor.R > oldColor.R) RColorDiff = NewColor.R + RColorDiff;
                        else RColorDiff = NewColor.R - RColorDiff;
                        if (RColorDiff > 255) RColorDiff = 255;
                        if (RColorDiff < 0) RColorDiff = 0;
                        if (PixelColor.G > oldColor.G) GColorDiff = NewColor.G + GColorDiff;
                        else GColorDiff = NewColor.G - GColorDiff;
                        if (GColorDiff > 255) GColorDiff = 255;
                        if (GColorDiff < 0) GColorDiff = 0;
                        if (PixelColor.B > oldColor.B) BColorDiff = NewColor.B + BColorDiff;
                        else BColorDiff = NewColor.B - BColorDiff;
                        if (BColorDiff > 255) BColorDiff = 255;
                        if (BColorDiff < 0) BColorDiff = 0;

                        outputImage.SetPixel(x, y, Color.FromArgb(RColorDiff, GColorDiff, BColorDiff));
                    }
                }
            return outputImage;
        }


        // Handle the method CreateTab that allows the user to create a new Tab
        // on your app when clicking

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {

                // The content will be an instance of another Form
                // In our example, we will create a new instance of the Form1
                Content = new Form1
                {

                    Text = "New Tab"
                }
            };
        }



        // The rest of the events in your app here if you need to .....
    }
}