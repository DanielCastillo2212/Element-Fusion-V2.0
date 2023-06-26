using UnityEngine;

public class DoorColisiones : MonoBehaviour
{
    private bool hasKey = false; // Indicador de si se ha recogido la llave

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Door") && hasKey)
        {   
            Debug.Log("Puerta abierta");
            collision.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Si el objeto que ha entrado en el trigger tiene la etiqueta "Key", entonces recogemos la llave
        if (other.CompareTag("Key"))
        {
            Debug.Log("Key collected");
            other.gameObject.SetActive(false);
            hasKey = true;
        }
    }
}



