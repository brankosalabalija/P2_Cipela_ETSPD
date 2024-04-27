using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemant : MonoBehaviour
{
    public Rigidbody2D rb;
    private float Horizontal;
    public int jumpForce = 18;
    public int speed = 5;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        // kretanje levo i desno
        rb.velocity = new Vector2(Horizontal * speed, rb.velocity.y); // kretanje po X osi(Horizontalnoj osi)
        
        //skakanje
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) // ispitvanje da li je pritsnut space
        {
            rb.velocity = Vector2.up * jumpForce; // dodavanje jacine skoka na igraca
        }
    }

    private bool IsGrounded ()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f , groundLayer);
    }
}
