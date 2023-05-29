using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObsticals : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject obstical;
    private float spawnTime = 2f;
    public float spawnBetweenRate = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time >= spawnTime)
        {
            spawnObsitcals();
            spawnTime = Time.time + spawnBetweenRate;
        }

        
    }


    

    private void spawnObsitcals()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (spawnPointIndex != i)
            {
                Instantiate(obstical, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
