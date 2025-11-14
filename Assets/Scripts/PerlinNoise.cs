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
    public float offsetXAdd;
    public float offsetYAdd;

    /*
    [Range(0f, 1f)]
    public float border = 0f;
    [Range(0f, 1f)]
    public float border2 = 0f;
    */

    public float timer;
    public float frequencyUpdate;
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
            timer = frequencyUpdate;
            offsetY += offsetYAdd;
            offsetX += offsetXAdd;
            hours += 1;
        }

        hours %= 24;
        //txt.text = hours.ToString();
    }

}
