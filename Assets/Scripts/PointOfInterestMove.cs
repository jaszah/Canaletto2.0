using UnityEngine;

public class PointOfInterestMove : MonoBehaviour
{

    public float speed = 10.0f;
    protected Joystick joystick;
    public Rigidbody2D rb;
    public Vector2 movement;
 

    void Start()
    {
        joystick = FindObjectOfType<Joystick>(); //mobile joystick
        rb = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        movement = new Vector2(joystick.Horizontal, joystick.Vertical); //mobile joystick
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));

    }

    

}
