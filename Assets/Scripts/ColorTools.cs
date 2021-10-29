using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ColorTools : MonoBehaviour
{
    public float alphaSize = 0.9f;
    public float addColor = 5;
    public bool Alpha = true;
    private Texture2D t2D;
    private Texture2D grayTexture;

    void Start()
    {
        if (Alpha)
        {
            SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            int width = spriteRenderer.sprite.texture.width;
            int height = spriteRenderer.sprite.texture.height;
            t2D = new Texture2D(width, height);
            grayTexture = new Texture2D(width, height);
            List<Color> defaultColors = new List<Color>();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color color = new Color(0, 0, 0, 0);
                    defaultColors.Add(color);
                }
            }
            grayTexture.SetPixels(defaultColors.ToArray());

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color color = spriteRenderer.sprite.texture.GetPixel(i, j);

                    float r = color.r;
                    float g = color.g;
                    float b = color.b;
                    float a = color.a;

                    if (a > 0)
                    {
                        grayTexture.SetPixel(i, j, new Color(color.grayscale, color.grayscale, color.grayscale));
                    }

                    float alpha = color.grayscale;
                    float addColorValue = 0;
                    if (a > 0)
                    {
                        alpha = alpha + alpha / alphaSize;
                        addColorValue = color.grayscale / addColor;
                    }

                    t2D.SetPixel(i, j, new Color(r + addColorValue, g + addColorValue, b + addColorValue, alpha));
                }
            }

            grayTexture.Apply();
            Utils.SavePng(Application.dataPath + @"\gray.png", grayTexture);

            t2D.Apply();
            spriteRenderer.sprite = Sprite.Create(t2D, new Rect(0, 0, width, height), new Vector2(0.5f, 0.5f), 100);
        }

        AssetDatabase.Refresh();
    }

    private void OnDestroy()
    {
        Destroy(t2D);
        Destroy(grayTexture);
    }
}
