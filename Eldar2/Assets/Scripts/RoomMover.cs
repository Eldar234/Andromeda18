
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMover : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = -Vector3.forward * speed;

        if (transform.position.z <= -8) 
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

}
