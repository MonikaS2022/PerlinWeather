using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureGenerator
{
    public static Texture2D Generate(int width, int height, float offsetX, float offsetY, float scale, FilterMode filterMode)
    {
        Texture2D texture = new Texture2D(width, height);
        texture.filterMode = filterMode;

        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                Color color = ColorCalculator.Perlin2DirectionsScrew(width, height, x, y, offsetX, offsetY, scale);
                texture.SetPixel(x, y, color);
            }
        }

        texture.Apply();
        return texture;
    }
}
