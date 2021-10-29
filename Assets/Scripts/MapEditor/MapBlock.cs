using System;
using UnityEngine;

public struct ColorEx
{
    public float r;
    public float g;
    public float b;

    public ColorEx(float r, float g, float b)
    {
        this.r = r;
        this.g = g;
        this.b = b;
    }
}

public class MapBlock
{
    public ColorEx[,] _blocks;
    public int _x = 0;
    public int _y = 0;
    public Texture2D texture2D = null;

    public MapBlock(int x, int y)
    {
        _x = x;
        _y = y;
        _blocks = new ColorEx[MapEditor.mapBlockSize_x, MapEditor.mapBlockSize_y];
        for (int i = 0; i < MapEditor.mapBlockSize_x; i++)
        {
            for (int j = 0; j < MapEditor.mapBlockSize_y; j++)
            {
                _blocks[i, j] = new ColorEx(0,0,0);
            }
        }
    }

    public bool Exist(int pixelX, int pixelY)
    {
        if (pixelX >= _x * MapEditor.mapBlockSize_x && pixelX < (_x + 1) * MapEditor.mapBlockSize_x && pixelY >= _y * MapEditor.mapBlockSize_y && pixelY < (_y + 1) * MapEditor.mapBlockSize_y)
        {
            return true;
        }

        return false;
    }

    public void SetColor(int pixelX, int pixelY, Color color)
    {
        int x = pixelX - _x * MapEditor.mapBlockSize_x;
        int y = pixelY - _y * MapEditor.mapBlockSize_y;

        try
        {
            _blocks[x, y] = new ColorEx(color.r, color.g, color.b);
        }
        catch
        {
            int error = 0;
        }
    }

    public Vector3 GetPosition
    {
        get
        {
            return new Vector3(_x * MapEditor.mapBlockSize_x / 100.0f, _y * MapEditor.mapBlockSize_y / 100.0f, 0);
        }
    }

    public Texture2D GetTexture2D
    {
        get
        {
            texture2D = new Texture2D(MapEditor.mapBlockSize_x, MapEditor.mapBlockSize_y);
            texture2D.filterMode = FilterMode.Bilinear;
            for (int i = 0; i < MapEditor.mapBlockSize_x; i++)
            {
                for (int j = 0; j < MapEditor.mapBlockSize_y; j++)
                {
                    texture2D.SetPixel(i, j, new Color(_blocks[i, j].r, _blocks[i, j].g, _blocks[i, j].b, 1));
                }
            }
            texture2D.Apply();

            return texture2D;
        }
    }

    public string GetName
    {
        get
        {
            return (MapEditor.blockYCount - 1 - _y) + "_" + _x;
        }
    }

    public void Dispose()
    {
        if (texture2D != null)
        {
            UnityEngine.Object.DestroyImmediate(texture2D);
            texture2D = null;
        }

        _blocks = null;
    }
}