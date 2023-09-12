using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fadeinandout : MonoBehaviour
{
    public Texture img;
    private static bool Fadein = false;
    private static bool FadeOut = false;

    private static string Scene;

    private float speed = 0.5f;
    private static float alpha = 0f;
    private void OnGUI()
    {
        if(FadeOut)
        {
            alpha += speed * Time.deltaTime;
            if(alpha>=1)
            {
                Fadein = true;
                FadeOut = false;
                SceneManager.LoadScene(Scene);
            }
        }
        if(Fadein)
        {
            alpha -= speed * Time.deltaTime;
            if(alpha<=0)
            {
                Fadein = false;
            }
        }

        GUI.color = new Color(GUI.color.r,GUI.color.g,GUI.color.b, alpha);
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img);
    }

    public static void changeScene(string scene)
    {
        if(Fadein) Fadein = false;
        FadeOut = true;
        Scene = scene;
    }

}
