using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    private Vector2 input;
    private Vector3 movement; 



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 

    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        movement = input.x * transform.right * speed + input.y * transform.forward * speed;

        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z); 
    }
}
