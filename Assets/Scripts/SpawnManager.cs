using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject Fireball;
    public float SpawnRate;
    public float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnFireball();
            timer = 0;
        }
    }

    void SpawnFireball()
    {
        SpawnRate = Random.Range(2.0f, 4.0f);

        Instantiate(Fireball, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
