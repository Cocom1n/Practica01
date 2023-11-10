using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn01 : MonoBehaviour
{
    [SerializeField] private GameObject enemigo;
    
    void Start()
    {
        InvokeRepeating("spawn", 0, 2);
    }

   void spawn ()
    {
        Instantiate(enemigo, transform.position, Quaternion.identity);
    }
}