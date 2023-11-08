using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float movimiento = Input.GetAxis("Horizontal");
        Vector3 direccion = new Vector3(movimiento, 0, 0);
        transform.Translate(direccion * speed * Time.deltaTime);
    }
}
