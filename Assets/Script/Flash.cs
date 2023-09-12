using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public Texture img;
    public float speed;

    private static bool flashing = false;
    private float alpha = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnGUI()
    {
        if(flashing)
        {
            alpha += speed * Time.deltaTime;
            if(alpha>=1)
            {
                flashing = false;
            }
        }
        else
        {
            if(alpha>0)
            {
                alpha -= speed * Time.deltaTime;
            }
        }

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img);
    }

    public static void flash()
    {
        flashing=true;
    }
}
