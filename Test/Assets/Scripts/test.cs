using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    
    public float speedMovement = 0.6f;
    public float jumpForce = 0.1f;
    float horizontalMovement;

    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalMovement, 0, 0);
        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rigidBody.velocity.y)<0.1){
            rigidBody.AddForce(new Vector2(0,jumpForce), ForceMode2D.Impulse);
        }
    }
}

