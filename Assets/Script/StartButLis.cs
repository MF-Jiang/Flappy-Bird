using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButLis : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        transform.localScale = transform.localScale * 0.8f;
    }

    private void OnMouseUp()
    {
        transform.localScale = transform.localScale / 0.8f;
        Player.life = true;
        ScoreCtrl.score = 0;
        audioSource.Play();
        Fadeinandout.changeScene("game");
    }
}
