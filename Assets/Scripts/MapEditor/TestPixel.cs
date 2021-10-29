using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPixel : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        int width = spriteRenderer.sprite.texture.width;
        int height = spriteRenderer.sprite.texture.height;

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                spriteRenderer.sprite.texture.SetPixel(i, j, Color.black);
            }
        }
        spriteRenderer.sprite.texture.Apply();
    }

    void Update()
    {
        
    }
}
