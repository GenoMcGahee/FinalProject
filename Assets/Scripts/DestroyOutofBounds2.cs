using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds2 : MonoBehaviour
{

    private float topBound = 160;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > topBound)
        {
            Destroy(gameObject);
        }
    }
}
