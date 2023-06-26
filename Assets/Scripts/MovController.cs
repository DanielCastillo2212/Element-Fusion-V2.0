using UnityEngine;

public class MovController : MonoBehaviour
{


    private Rigidbody2D rb;
    private float yVelocity = 0f;
    private float xVelocity = 10f;
    public float jumpForce = 100f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        yVelocity = rb.velocity.y;
        rb.velocity = new Vector2(0, yVelocity);
        
        if (Input.GetKey(KeyCode.LeftArrow)) 
            rb.velocity = new Vector2 (-xVelocity, yVelocity);

        if (Input.GetKey(KeyCode.RightArrow))
            rb.velocity = new Vector2(xVelocity, yVelocity);

        if (Input.GetKeyUp(KeyCode.UpArrow))
            rb.AddForce(Vector2.up * jumpForce);
    }
}
