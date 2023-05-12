using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.0f;
<<<<<<< Updated upstream
    public float RotateSpeed = 30.0f;
    private Rigidbody playerRb;
    private Rigidbody rb;
     
=======
    private Rigidbody playerRb;
    private Rigidbody rb;
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
           float moveHorizontal = Input.GetAxis ("Horizontal");
     float moveVertical = Input.GetAxis ("Vertical");
<<<<<<< Updated upstream
     Vector3 movement = new Vector3 (moveHorizontal, moveVertical);
     rb.AddForce (movement);
           if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
=======
     Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
     rb.AddForce (movement);
         
>>>>>>> Stashed changes
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
