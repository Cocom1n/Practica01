using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo01Move : MonoBehaviour
{
    [SerializeField] private GameObject balaPrefab;
    private float speed = 3;
    private float intervalo = 1;

    void Start ()
    {
        InvokeRepeating("Disparar", 0, intervalo);
    }

    void Update()
    {
        gameObject.transform.position += new Vector3 (- speed * Time.deltaTime, 0, - speed * Time.deltaTime);  
        if(gameObject.transform.position.x <= -4.5f)
        {
            Destroy(gameObject);
        }
    }

    void Disparar ()
    {
        Instantiate(balaPrefab, transform.position, Quaternion.identity);
    }
}
