using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{
    public List<Texture2D> texture2Ds;
    public float time = 0.2f;
    private int index = -1;
    private float playerTime;
    private SpriteRenderer spriteRenderer;
    public bool AutoPlay = true;

    private void Start()
    {
        playerTime = time;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (!AutoPlay)
            return;

        if (texture2Ds == null)
            return;

        if (spriteRenderer == null)
            return;

        playerTime -= Time.deltaTime;
        if (playerTime <= 0)
        {
            playerTime = time;
            index++;

            if (index == texture2Ds.Count)
            {
                index = 0;
            }

            Texture2D texture2D = texture2Ds[index];
            Sprite sp = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));
            spriteRenderer.sprite = sp;
        }
    }
}
