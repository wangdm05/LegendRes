using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using B83.Image.BMP;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

public class Offset
{
    public int x;
    public int y;

    public bool IsEmpty()
    {
        return x == 0 && y == 0;
    }
}

public class BmpData
{
    public string bmpPath;
    public string pngPath;
    public string offsetPath;
    public bool alpha;
    public float alphaSize = 0;
    public float addColor = 0;

    public bool effectAlpha;
    public float effectAlphaSize = 0;
    public float effectAddColor = 0;
}

public class BmpToPng
{
    private static List<Color> defaultColors = new List<Color>();
    private static int maxWidth = 2048;
    private static int maxHeight = 2048;

    public static void BmpToPngAction(BmpData bmpData)
    {
        InitTransparentColor();
        string text = File.ReadAllText(bmpData.offsetPath);
        string[] offsets = text.Split(new char[2] { '\r', '\n' });

        Offset offset = new Offset();
        offset.x = int.Parse(offsets[0]);
        offset.y = int.Parse(offsets[2]);

        Texture2D t2D = Utils.BmpToTexture2D(bmpData.bmpPath);

        #region 重心偏移
        int offsetx = -25;
        int offsety = 19;
        #endregion

        #region 起始点计算
        //该资源坐标系左上角为0,0点
        //unity中左下角为0,0点

        //x起始位置计算大图的中心点+offset.x即可
        //y起始位置计算 由于资源的坐标0,0和unity中的0,0 y轴向相反 图片的高度+offset.y 大图的中心点-减去偏移值

        int startX = maxWidth / 2 + offset.x + offsetx;
        int StartY = maxHeight / 2 - (t2D.height + offset.y) + offsety;
        #endregion

        //放到一张大图上
        Texture2D pngTexture = new Texture2D(maxWidth, maxHeight);
        pngTexture.SetPixels(defaultColors.ToArray());

        for (int colori = 0; colori < t2D.width; colori++)
        {
            for (int colorj = 0; colorj < t2D.height; colorj++)
            {
                Color color = t2D.GetPixel(colori, colorj);
                float r = color.r;
                float g = color.g;
                float b = color.b;
                float a = color.a;
                float addColorValue = 0;

                if (r == 0 && g == 0 && b == 0)
                {
                    a = 0;
                }
                else
                {
                    if (bmpData.effectAlpha)
                    {
                        float alpha = color.grayscale;
                        
                        if (a > 0)
                        {
                            alpha = alpha + alpha / bmpData.effectAlphaSize;
                            addColorValue = color.grayscale / bmpData.effectAddColor;
                        }

                        a = alpha;
                    }
                }

                color = new Color(r + addColorValue, g + addColorValue, b + addColorValue, a);
                pngTexture.SetPixel(colori + startX, colorj + StartY, color);
            }
        }

        pngTexture.Apply();
        Utils.SavePng(bmpData.pngPath, pngTexture);

        UnityEngine.Object.DestroyImmediate(t2D, true);
        UnityEngine.Object.DestroyImmediate(pngTexture, true);
    }

    public static void BmpToPngUI(BmpData bmpData)
    {
        System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(bmpData.bmpPath);
        MemoryStream ms = new MemoryStream();
        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

        var buffer = new byte[ms.Length];
        ms.Position = 0;
        ms.Read(buffer, 0, buffer.Length);
        Texture2D t2D = new Texture2D(1, 1);
        t2D.LoadImage(buffer);
        t2D.Apply();

        for (int i = 0; i < t2D.width; i++)
        {
            for (int j = 0; j < t2D.height; j++)
            {
                Color color = t2D.GetPixel(i, j);

                float r = color.r;
                float g = color.g;
                float b = color.b;
                float a = color.a;

                float max = Math.Max(Math.Max(r, g), b);

                if (r == 0 && g == 0 && b == 0)
                {
                    a = 0;
                }
                else
                {
                    a = max;
                }

                color = new Color(r, g, b, a);
                t2D.SetPixel(i, j, color);
            }
        }

        t2D.Apply();

        Utils.SavePng(bmpData.pngPath, t2D);
        UnityEngine.Object.DestroyImmediate(t2D, true);
    }

    static byte Max(params byte[] values)
    {
        if (values == null || values.Length == 0)
            return 0;
        var max = values[0];
        for (var i = 1; i < values.Length; ++i)
        {
            max = Math.Max(max, values[i]);
        }
        return max;
    }

    static byte Min(params byte[] values)
    {
        if (values == null || values.Length == 0)
            return 0;
        var min = values[0];
        for (var i = 1; i < values.Length; ++i)
        {
            min = Math.Min(min, values[i]);
        }
        return min;
    }

    public static Texture2D LoadTexture(string filePath)
    {
        Texture2D tex = null;

        if (File.Exists(filePath))
        {
            BMPLoader bmpLoader = new BMPLoader();
            //bmpLoader.ForceAlphaReadWhenPossible = true; //Uncomment to read alpha too

            //Load the BMP data
            BMPImage bmpImg = bmpLoader.LoadBMP(filePath);

            //Convert the Color32 array into a Texture2D
            tex = bmpImg.ToTexture2D();
        }
        return tex;
    }

    public static void InitTransparentColor()
    {
        if (defaultColors.Count > 0)
            return;

        for (int i = 0; i < maxWidth; i++)
        {
            for (int j = 0; j < maxHeight; j++)
            {
                Color color = new Color(0, 0, 0, 0);
                defaultColors.Add(color);
            }
        }
    }
}
