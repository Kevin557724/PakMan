using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour

{
     public GameObject Player;
    private Vector3 offset;
    public float RotateSpeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
          offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
          transform.position = Player.transform.position + offset;
    }
}
