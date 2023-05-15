using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour

{
     public GameObject Player;
    private Vector3 offset = new Vector3 (196,10,-165);
   
    // Start is called before the first frame update
    void Start()
    {
          offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
          transform.position = Player.transform.position + offset;
    }
}
