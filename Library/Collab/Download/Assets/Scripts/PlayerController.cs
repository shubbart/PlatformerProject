using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float jumpSpeed;
    public float baseHeight;
    private bool isJumping = false;
    // Use this for initialization
    void Start()
    {

    }

   private void OnCollisionEnter(Collision other)
    {    
        if(other.gameObject.tag == "Ground" || other.gameObject.tag == "Enemy")
        {
            isJumping = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");
        Rigidbody rbody = GetComponent<Rigidbody>();
        Vector2 input = new Vector2(horizontal, 0);
        input *= speed;
        rbody.AddForce(input);

        baseHeight = transform.position.y;

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            Vector2 jInput = new Vector2(0, jump);
            jInput *= jumpSpeed;
            rbody.AddForce(jInput, ForceMode.Impulse);
            isJumping = true;
        }
    }
}
