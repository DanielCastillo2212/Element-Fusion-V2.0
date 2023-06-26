using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YCuchillaLv01 : MonoBehaviour
{
     public float movementSpeed = 2f; // Velocidad de movimiento en unidades por segundo
    public float movementRange = 5f; // Rango máximo de movimiento en unidades
    private bool movingUp = true; // Indicador de dirección de movimiento
    private Vector3 initialPosition; // Posición inicial del objeto

    // Start is called before the first frame update
    void Start()
    {
        // Almacenar la posición inicial del objeto
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Mover el objeto en el eje Y
        if (movingUp)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }

        // Cambiar la dirección de movimiento si alcanza el límite
        if (transform.position.y >= initialPosition.y + movementRange)
        {
            movingUp = false;
        }
        else if (transform.position.y <= initialPosition.y - movementRange)
        {
            movingUp = true;
        }
    }
}
