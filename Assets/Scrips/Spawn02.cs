using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn02 : MonoBehaviour
{
    [SerializeField] private GameObject enemigo;
    [SerializeField]private float cantEnemigos = 5;
    private float speed = 2;
    private bool direccion = true;
    
    void Start()
    {
        InvokeRepeating("spawn", 1, 2);
    }

    void Update()
    {
        if(direccion)
        {
            gameObject.transform.position += new Vector3 (0, 0, speed * Time.deltaTime); 
        }
        else
        {
            gameObject.transform.position += new Vector3 (0, 0, -speed * Time.deltaTime);
        }

        if (transform.position.z >= 4 || transform.position.z <= -4)
        {
            direccion = !direccion;
        }   
    }

    void spawn()
    {
        if(cantEnemigos>0)
        {
            Instantiate(enemigo, transform.position, Quaternion.identity);
            cantEnemigos-=1;
        }
    }
}
