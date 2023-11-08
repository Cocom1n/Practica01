using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    void Start ()
    {
        Destroy(gameObject, 1);
    }

    void Update()
    {
        gameObject.transform.position += new Vector3 (0, 0, speed * Time.deltaTime);  
    }
}
