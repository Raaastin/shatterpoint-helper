using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Platform;
using System;
using System.IO;
using System.Reflection;

namespace Struggle.Pal.Services
{
    public class GraphicsDrawable : IDrawable
    {
        public double Scale { get; set; }
        public Point Center { get; set; }
        public Rect DisplayedRect { get; set; }

        private Microsoft.Maui.Graphics.IImage image;

        public GraphicsDrawable(string source)
        {
            // Charger l'image depuis les ressources
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            using (Stream stream = assembly.GetManifestResourceStream($"Struggle.Pal.Resources.Images.{source}"))
            {
                image = PlatformImage.FromStream(stream);
            }
        }

        public void Draw(ICanvas canvas, RectF containerRect)
        {
            if (image != null)
            {
                // Calculer la portion de l'image à afficher
                double scaledWidth = image.Width / Scale;
                double scaledHeight = image.Height / Scale;
                double xCenterImageOUT = Center.X * image.Width;
                double xLeft = Math.Max(0, xCenterImageOUT - scaledWidth / 2);
                double xRight = Math.Min(xCenterImageOUT + scaledWidth / 2, image.Width);
                double yCenterImageOUT = Center.Y * image.Height;
                double yTop = Math.Max(0, yCenterImageOUT - scaledHeight / 2);
                double yBottom = Math.Min(yCenterImageOUT + scaledHeight / 2, image.Height);

                DisplayedRect = new Rect(xLeft, yTop, scaledWidth, scaledHeight);

                // Dessiner l'image
                canvas.DrawImage(image, containerRect.X, containerRect.Y, containerRect.Width, containerRect.Height);
            }
        }
    }
}

