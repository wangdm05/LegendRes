using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using UnityEngine;

public class ImageToTexture
{
    public static byte[] bmpBytes;
    public static Texture2D background;

    public static Texture2D ConvertBitmapToTexture(Bitmap b)
    {
        BitmapData bData = b.LockBits(new System.Drawing.Rectangle(new System.Drawing.Point(), b.Size),
            ImageLockMode.ReadOnly,
            PixelFormat.Format32bppRgb);

        // number of bytes in the bitmap
        int byteCount = bData.Stride * b.Height;
        if (bmpBytes == null ||
            bmpBytes.Length != byteCount)
            bmpBytes = new byte[byteCount];

        // Copy the locked bytes from memory
        Marshal.Copy(bData.Scan0, bmpBytes, 0, byteCount);

        // don't forget to unlock the bitmap!!
        //b.UnlockBits(bData);

        background = new Texture2D(b.Width, b.Height);
        background.LoadImage(bmpBytes);
        background.Apply();

        return background;
    }

    public static void Dispose()
    {
        if (background != null)
        {
            UnityEngine.Object.DestroyImmediate(background);
            background = null;
        }

        bmpBytes = null;
    }
}
