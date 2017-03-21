using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour {

    public GameObject bullet;
    public float speed;
    public float jumpSpeed;
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

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            Vector2 jInput = new Vector2(0, jump);
            jInput *= jumpSpeed;
            rbody.AddForce(jInput, ForceMode.Impulse);
            isJumping = true;
        }

        if (Input.GetButtonDown("Fire1") && Input.GetKey("a"))
        {
            GameObject pewpew = Instantiate(bullet, transform.position + new Vector3(-.5f, .4f, 0), bullet.transform.rotation);
            pewpew.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0) * -10, ForceMode.Impulse);
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            GameObject pewpew = Instantiate(bullet, transform.position + new Vector3(.5f, .4f, 0), bullet.transform.rotation);
            pewpew.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0) * 10, ForceMode.Impulse);
        }
    }
}
