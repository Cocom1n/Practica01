using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo02Move : MonoBehaviour
{
    [SerializeField] private GameObject balaPrefab;
    private float speed = 3;
    private float intervalo;
    private bool direccion = true;

    void Start ()
    {
        intervalo = Random.Range(0.1f ,3);
        InvokeRepeating("Disparar", 0, intervalo);
    }

    void Update()
    {
        if(direccion)
        {
            gameObject.transform.position += new Vector3 (speed * Time.deltaTime, 0,0); 
        }
        else
        {
            gameObject.transform.position += new Vector3 (-speed * Time.deltaTime, 0,0);
        }

        if (transform.position.x >= 5 || transform.position.x <= -5)
        {
            direccion = !direccion;
        }
        
    }

    void Disparar ()
    {
        Instantiate(balaPrefab, transform.position, Quaternion.identity);
    }
}
