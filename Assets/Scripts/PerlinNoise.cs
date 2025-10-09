using TMPro;
using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public Renderer Renderer;
    //public TextMeshProUGUI txt;
    public FilterMode FilterMode;
    public int width;
    public int height;

    public float scale;

    public float offsetX;
    public float offsetY;

    /*
    [Range(0f, 1f)]
    public float border = 0f;
    [Range(0f, 1f)]
    public float border2 = 0f;
    */

    float timer;
    int hours;

    private void Start()
    {
        Renderer = GetComponent<Renderer>();
        timer = 0f;
        //hours = 0;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0f)
        {
            Renderer.material.mainTexture = TextureGenerator.Generate(width, height, offsetX, offsetY, scale, FilterMode);
            timer = 0.5f;
            //offsetY += 0.02f;
            //offsetX += 0.04f;
            //hours += 1;
        }

        //hours %= 24;
        //txt.text = hours.ToString();
    }

}
