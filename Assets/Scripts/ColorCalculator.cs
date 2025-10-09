using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class ColorCalculator
{
    

    public static Color Perlin2DirectionsScrew(int width, int height, int x, int y, float offsetX, float offsetY, float scale)
    {
        Color color = new Color(0, 0, 0);


        float xCoord = (float)x / width * scale + offsetX;
        float yCoord = (float)y / height * scale + offsetY;

        /*
        float xCoord = (float)x / width * scale + offsetX; //with directional vector
        float yCoord = (float)y / width * scale + offsetY;
        */

        /*
        float xCoord = (float)x / width * scale + offsetX * -0.5f; //with directional vector
        float yCoord = (float)y / width * scale + offsetY * -0.6f;

        //screw - new position from old position
        float yCoord2 = (float)y / height * scale + offsetY * -1;

        Vector2 newPos = new Vector2(Mathf.PerlinNoise(xCoord, yCoord), Mathf.PerlinNoise(xCoord, yCoord2));
        */

        float sample = Mathf.PerlinNoise(xCoord, yCoord);

        color = new Color(sample, sample, sample);
        


        return color;
    }
}
