using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalMovController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float yVelocity = 0f;
    public float xVelocity = 20f;
    public float jumpForce = 100f;
    public float gravityScale = 1f;
    public float mass = 1f;
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityScale; // Configurar la escala de gravedad del Rigidbody2D
        rb.mass = mass; // Configurar la masa del Rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        yVelocity = rb.velocity.y;
        rb.velocity = new Vector2(0, yVelocity);

        if (Input.GetKey(KeyCode.A))
            rb.velocity = new Vector2(-xVelocity, yVelocity);

        if (Input.GetKey(KeyCode.D))
            rb.velocity = new Vector2(xVelocity, yVelocity);

        if (Input.GetKeyUp(KeyCode.W) && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpForce);
            isJumping = true;
        }
    }

    // Detectar colisiones con el suelo para restablecer el indicador de salto
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
