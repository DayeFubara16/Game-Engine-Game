using UnityEngine;

public class MainPlayerController : MonoBehaviour
{

    // varaibles include a rigidbody, movement float for our transform 
    // movement speed and a jump force 
    private Rigidbody2D rigidbody;
    private float movement;
    public float movementSpeed = 5.0f;
    public float jumpForce = 3.0f;

    private void Start()
    {
        //Set up Rigidbody 
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Collecting the standard horizonatal movement 
        movement = Input.GetAxis("Horizontal");
        // transforming the x value to move left or right
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
        

        //our jump 
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) < 0.001f)
        {
            rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
