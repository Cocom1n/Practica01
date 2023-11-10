using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float direccion;

    void Start ()
    {

    }

    void Update()
    {
        gameObject.transform.position += new Vector3 (0, 0, direccion * speed * Time.deltaTime);  


        if(direccion == 1)
        {
            if(gameObject.transform.position.z >= 5f )
            {
                Destroy(gameObject);
            }
        }
        else{
            if(gameObject.transform.position.z <= -5f )
            {
                Destroy(gameObject);
            }
        }
        
    }
}
