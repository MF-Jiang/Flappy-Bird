using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueBG : MonoBehaviour
{
    public GameObject ContinueBGPrefab;
    public float distance;
    private bool hasSpawned = false;
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasSpawned && Player.life)
        {
            time += Time.deltaTime;
            if(time > 3)
            {
                Destroy(ContinueBGPrefab); 
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!hasSpawned)
        {
            hasSpawned = true;
            Instantiate(ContinueBGPrefab, new Vector3(transform.position.x + distance, transform.position.y, transform.position.z), transform.rotation);
        }
        
    }
}
