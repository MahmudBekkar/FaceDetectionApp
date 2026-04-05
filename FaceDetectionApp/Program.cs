using System;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

class Program
{
    static void Main()
    {
        try
        {
            Mat image = CvInvoke.Imread("person.jpg", Emgu.CV.CvEnum.ImreadModes.Unchanged);

            if (image.IsEmpty)
            {
                Console.WriteLine("Image not found!");
                return;
            }

            CascadeClassifier faceCascade =
                new CascadeClassifier("data/haarcascade_frontalface_default.xml");

            Mat gray = new Mat();
            CvInvoke.CvtColor(image, gray, ColorConversion.Bgr2Gray);

            Rectangle[] faces = faceCascade.DetectMultiScale(gray, 1.1, 5);

            foreach (Rectangle face in faces)
            {
                CvInvoke.Rectangle(image, face, new MCvScalar(0, 255, 0), 2);
            }

            image.Save("result.jpg");

            Console.WriteLine("Done!");
            Console.WriteLine("Faces found: " + faces.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}