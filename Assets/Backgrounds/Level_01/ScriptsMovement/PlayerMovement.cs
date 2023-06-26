using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f; // Velocidad de movimiento lateral
    public float jumpForce = 5f; // Fuerza del salto
    public float gravityScale = 2f; // Escala de gravedad para el personaje
    public float mass = 1f; // Masa del personaje
    private bool isJumping = false; // Indicador de salto
    private Rigidbody2D rb; // Referencia al componente Rigidbody2D
    private SpriteRenderer spriteRenderer; // Referencia al componente SpriteRenderer

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtener referencia al componente Rigidbody2D
        spriteRenderer = GetComponent<SpriteRenderer>(); // Obtener referencia al componente SpriteRenderer
        rb.gravityScale = gravityScale; // Configurar la escala de gravedad del Rigidbody2D
        rb.mass = mass; // Configurar la masa del Rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento lateral (izquierda y derecha)
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * movementSpeed, rb.velocity.y);

        // Cambiar la dirección del sprite según el movimiento
        if (moveHorizontal < 0f)
        {
            spriteRenderer.flipX = true; // Invertir el sprite horizontalmente
        }
        else if (moveHorizontal > 0f)
        {
            spriteRenderer.flipX = false; // Restaurar la orientación del sprite
        }

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    // Detectar colisiones con el suelo para restablecer el indicador de salto
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Suelo detectada");
            isJumping = false;
        }
    }

    // Detectar colisiones de tipo Trigger con la sierra
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sierra"))
        {
            Debug.Log("Sierra detectada");
        }
    }
}








