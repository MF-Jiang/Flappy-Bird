using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButLis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        //SceneManager.LoadScene("game");
        Fadeinandout.changeScene("game");
    }
}
