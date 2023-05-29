using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstical : MonoBehaviour
{


    private float destroyPosition = -6f;
    public float gravityScaleRate = 20f;


    private void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityScaleRate;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < destroyPosition)
        {
            Destroy(gameObject);
        }
    }
}
