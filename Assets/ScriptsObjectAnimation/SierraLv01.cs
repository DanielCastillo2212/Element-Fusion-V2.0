using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SierraLv01 : MonoBehaviour
{
    public float movementSpeed = 2f; // Velocidad de movimiento en unidades por segundo
    public float movementRange = 5f; // Rango máximo de movimiento en unidades
    private bool movingRight = true; // Indicador de dirección de movimiento
    private Vector3 initialPosition; // Posición inicial del objeto

    void Start()
    {
        initialPosition = transform.position; // Guardar la posición inicial del objeto
    }

    // Update is called once per frame
    void Update()
    {
        // Mover el objeto en el eje X
        if (movingRight)
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }

        // Cambiar la dirección de movimiento si alcanza el límite
        if (transform.position.x >= initialPosition.x + movementRange)
        {
            movingRight = false;
        }
        else if (transform.position.x <= initialPosition.x - movementRange)
        {
            movingRight = true;
        }
    }
}



