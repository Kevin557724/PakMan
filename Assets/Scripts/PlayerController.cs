using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody playerRb;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
           float moveHorizontal = Input.GetAxis ("Horizontal");
     float moveVertical = Input.GetAxis ("Vertical");
     Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
     rb.AddForce (movement);
         
    }

    // Update is called once per frame
    void Update()
    {
         float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
       
         playerRb.AddForce(Vector3.forward *speed * verticalInput);
        playerRb.AddForce(Vector3.right* speed* horizontalInput);
    }
}
