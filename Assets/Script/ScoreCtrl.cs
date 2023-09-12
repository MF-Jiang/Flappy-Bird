using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCtrl : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    private AudioSource scoreSource;
    private bool GetStart = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Canvas/Text").GetComponent<Text>();
        scoreSource = GetComponent<AudioSource>();  
    }

    private void OnGUI()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!GetStart)
        {
            score++;
            scoreSource.Play();
        }
        GetStart = true;
    }

}
