using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextureSize
{
    public int width;
    public int height;
}

public class Utils
{
    private static TextureSize textureSize = new TextureSize();
    public static Texture2D BmpToTexture2D(string bmpPath)
    {
        System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(bmpPath);

        MemoryStream ms = new MemoryStream();
        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

        var buffer = new byte[ms.Length];
        ms.Position = 0;
        ms.Read(buffer, 0, buffer.Length);
        Texture2D t2D = new Texture2D(1, 1);
        t2D.LoadImage(buffer);
        t2D.Apply();

        return t2D;
    }

    public static TextureSize GetBmpWidthHeight(string bmpPath)
    {
        System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(bmpPath);
        textureSize.width = bitmap.Width;
        textureSize.height = bitmap.Height;
        bitmap.Dispose();
        return textureSize;
    }

    public static void SavePng(string path, Texture2D tex)
    {
        if (string.IsNullOrEmpty(path))
            return;

        if (tex == null)
            return;

        FileStream fileStream = null;
        BinaryWriter binaryWriter = null;
        byte[] bytes = null;

        try
        {
            bytes = tex.EncodeToPNG();
            fileStream = File.Open(path, FileMode.Create);
            binaryWriter = new BinaryWriter(fileStream);
            binaryWriter.Write(bytes);
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
        finally
        {
            if (fileStream != null)
            {
                fileStream.Close();
                fileStream.Dispose();
            }

            if (binaryWriter != null)
            {
                binaryWriter.Close();
                binaryWriter.Dispose();
            }

            bytes = null;
        }
    }

    public static List<string> FindFiles(string path, string filter = "*")
    {
        List<string> filePaths = new List<string>();
        if (Directory.Exists(path))
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles(filter, SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                filePaths.Add(files[i].FullName);
            }
        }

        return filePaths;
    }
}
