using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarCtrl : MonoBehaviour
{
    public float UpL;
    public float DownL;

    private float speed;
    private bool CouldMove;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.5f, 2.5f);
        CouldMove = Random.Range(0, 2) == 0 ? true : false;
    }

    // Update is called once per frame
    void Update()
    {
        if(CouldMove)
        {
            if(transform.position.y>UpL)
            {
                transform.position = new Vector3(transform.position.x, UpL, transform.position.z);
                speed = -speed;
            }
            if(transform .position.y<DownL)
            {
                transform.position = new Vector3(transform.position.x, DownL, transform.position.z);
                speed = -speed;
            }

            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
        }
    }
}
