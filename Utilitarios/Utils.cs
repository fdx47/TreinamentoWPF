﻿using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TreinamentoWPF.Utilitarios;

public static class Utils
{
    public static byte[] ConvertBitmapSourceToByteArray(BitmapEncoder encoder, ImageSource imageSource)
    {
        byte[] bytes = null;
        var bitmapSource = imageSource as BitmapSource;

        if (bitmapSource != null)
        {
            encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

            using (var stream = new MemoryStream())
            {
                encoder.Save(stream);
                bytes = stream.ToArray();
            }
        }

        return bytes;
    }

    public static byte[] ConvertBitmapSourceToByteArray(BitmapSource image)
    {
        byte[] data;
        BitmapEncoder encoder = new JpegBitmapEncoder();
        encoder.Frames.Add(BitmapFrame.Create(image));
        using (MemoryStream ms = new MemoryStream())
        {
            encoder.Save(ms);
            data = ms.ToArray();
        }
        return data;
    }
    public static byte[] ConvertBitmapSourceToByteArray(ImageSource imageSource)
    {
        var image = imageSource as BitmapSource;
        byte[] data;
        BitmapEncoder encoder = new JpegBitmapEncoder();
        encoder.Frames.Add(BitmapFrame.Create(image));
        using (MemoryStream ms = new MemoryStream())
        {
            encoder.Save(ms);
            data = ms.ToArray();
        }
        return data;
    }
    public static byte[] ConvertBitmapSourceToByteArray(Uri uri)
    {
        var image = new BitmapImage(uri);
        byte[] data;
        BitmapEncoder encoder = new JpegBitmapEncoder();
        encoder.Frames.Add(BitmapFrame.Create(image));
        using (MemoryStream ms = new MemoryStream())
        {
            encoder.Save(ms);
            data = ms.ToArray();
        }
        return data;
    }
    public static byte[] ConvertBitmapSourceToByteArray(string filepath)
    {
        var image = new BitmapImage(new Uri(filepath));
        byte[] data;
        BitmapEncoder encoder = new JpegBitmapEncoder();
        encoder.Frames.Add(BitmapFrame.Create(image));
        using (MemoryStream ms = new MemoryStream())
        {
            encoder.Save(ms);
            data = ms.ToArray();
        }
        return data;
    }

    public static BitmapImage ConvertByteArrayToBitmapImage(Byte[] bytes)
    {
        try
        {
            var stream = new MemoryStream(bytes);
            stream.Seek(0, SeekOrigin.Begin);
            var image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();
            return image;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

}
