using UnityEngine;

public class GPU_Texture2D
{
    public Texture texture;

    public int width;
    public int height;

    public bool useGPU = true;
    // 預設使用 GPU ，用戶也能設定成 false 換成 CPU 運算

    ComputeShader shader;

    xColor[] xColorArray;

    Texture2D cpuTexture2D;

    public GPU_Texture2D(ComputeShader shader, bool useGPU, int width, int height)
    {
        this.useGPU = useGPU;
        this.width = width;
        this.height = height;

        if (useGPU)
        {
            this.shader = shader;
            xColorArray = new xColor[width * height];

        }
        else
        {
            cpuTexture2D = new Texture2D(width, height, TextureFormat.RGBAFloat, false);
            // 設成透明
            Color[] c = new Color[width * height];
            cpuTexture2D.SetPixels(c);
        }
    }

    // 你用 CPU 的話，建議用這個
    public void SetPixel(int x, int y, Color color)
    {
        if (useGPU)
        {
            int i = (width * y) + x;
            xColorArray[i].color = (Vector4)color;
        }
        else
        {
            cpuTexture2D.SetPixel(x, y, color);
        }
    }

    // 你用 GPU 的話，建議用這個
    public void SetPixel(int x, int y, Vector4 color)
    {
        if (useGPU)
        {
            int i = (width * y) + x;
            xColorArray[i].color = color;

        }
        else
        {
            cpuTexture2D.SetPixel(x, y, (Color)color);
        }
    }

    public void Apply()
    {
        if (useGPU)
        {
            GPU_Apply();
        }
        else
        {
            CPU_Apply();
        }
    }

    void CPU_Apply()
    {
        cpuTexture2D.Apply();
        texture = cpuTexture2D;
    }


    void GPU_Apply()
    {
        RenderTexture rTexture = new RenderTexture(width, height, 24);
        rTexture.enableRandomWrite = true;
        rTexture.Create();
        texture = rTexture;

        ComputeBuffer inputbuffer = new ComputeBuffer(xColorArray.Length, 16);

        int k = shader.FindKernel("CSMain");

        // 寫入 GPU
        inputbuffer.SetData(xColorArray);
        shader.SetBuffer(k, "colors", inputbuffer);

        shader.SetInt("width", width);
        shader.SetInt("height", height);

        shader.SetTexture(k, "Result", texture);
        shader.Dispatch(k, width / 8 + 1, height / 8 + 1, 1);

        inputbuffer.Release();
    }

    struct xColor
    {
        public Vector4 color;
    }
}