using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UIElements;

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

    public static Color CalculateColor(int width, int height, int x, int y, float offsetX, float offsetY, float scale)
    {
        Color color = new Color(0, 0, 0);
        //from int to float from 256 to 0 - 1
        float xCoord = (float)x / width * scale + offsetX * -0.5f; //with directional vector
        float yCoord = (float)y / height * scale + offsetY * -0.6f; // with directional vector
        //float xCoord = (float)x / width * scale + offsetX;
        //float yCoord = (float)y / height * scale + offsetY;
        //float sample = Mathf.PerlinNoise(xCoord, yCoord);

        //screw - new pos from old position
        float yCoord2 = (float)y / height * scale + offsetY * -1;
        Vector2 newPos = new Vector2(Mathf.PerlinNoise(xCoord, yCoord), Mathf.PerlinNoise(xCoord, yCoord2));
        float sample2 = Mathf.PerlinNoise(newPos.x, newPos.y);

        //float xCoord1 = (float)x / width * 2f + offsetX;
        //float yCoord1 = (float)y / height * 2f + offsetY;
        float yCoor32 = (float)y / height * 2f + offsetY * -4;
        Vector2 newPos3 = new Vector2(Mathf.PerlinNoise(xCoord, yCoord), Mathf.PerlinNoise(xCoord, yCoor32));

        float sample3 = Mathf.PerlinNoise(newPos3.x, newPos3.y);

        if (sample3 < 0.9f && sample3 > 0.3f)
        {
            if (sample3 < 0.35f)
            {
                //return Color.cyan;
                return new Color(0, 1, 1, 0.15f);
            }
            else
            {
                //return Color.white;
                return new Color(0, 0, 1, 0.0f);
            }
        }

        else
        {
            //return new Color(sample2, sample2, sample2);
            if (sample2 < 0.1f)
            {
                return Color.black;
            }
            else if (sample2 < 0.2f)
            {
                return new Color(0.2f, 0.2f, 0.2f);
            }
            else if (sample2 < 0.3f)
            {
                return new Color(0.3f, 0.3f, 0.3f);
            }
            else if (sample2 < 0.4f)
            {
                return new Color(0.4f, 0.4f, 0.4f);
            }
            else if (sample2 < 0.5f)
            {
                return new Color(0.5f, 0.5f, 0.5f);
            }
            else if (sample2 < 0.8f)
            {
                return new Color(0.8f, 0.8f, 0.8f);
            }
            else
            {

                return Color.white;
            }


            //return new Color(sample2, sample2, sample2);
        }
    }
}
