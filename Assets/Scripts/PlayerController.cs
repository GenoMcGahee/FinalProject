using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public GameObject arrowPrefab;
    public GameObject arrowPrefab2;
    public float fireRate;
    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);


        if ((Input.GetKeyDown(KeyCode.L)) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(arrowPrefab, transform.position, arrowPrefab.transform.rotation);
            
        }
        
        if ((Input.GetKeyDown(KeyCode.K)) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(arrowPrefab2, transform.position, arrowPrefab.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
