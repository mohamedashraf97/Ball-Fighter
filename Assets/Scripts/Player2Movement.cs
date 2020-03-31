using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private float movSpeed = 70f;
    public bool isGrounded;
    public GameObject fire;
    public bool dead2 = false;


    Vector3 movement;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        movement.z = Input.GetAxisRaw("Horizontal2");
        movement.x = -Input.GetAxisRaw("Vertical2");
        if (Input.GetKey("z") && isGrounded)
        {
            rb.AddForce(Vector3.up * 5500);
            isGrounded = false;
        }
        else if (!isGrounded)
        {
            rb.AddForce(Vector3.up * -400);
        }
        else if (transform.position.y > 114f)
        {
            rb.AddForce(Vector3.up * -1000);
        }

        rb.MovePosition(rb.position + movement * movSpeed * Time.fixedDeltaTime);

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        else if (other.gameObject.tag == "Lava")
        {
            Instantiate(fire, transform.position, transform.rotation);
            dead2 = true;
            Destroy(gameObject);

        }
        else if ((other.gameObject.tag == "Resize"))
        {
            transform.localScale = new Vector3(30f, 30f, 30f);
        }
    }
}
