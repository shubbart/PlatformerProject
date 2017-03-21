using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHead : MonoBehaviour
{

    public GameObject player;
    public GameObject self;
    private Vector3 offset;
    private Vector3 movement;   

    void Start()
    {
        offset = transform.position - player.transform.position;
        movement = new Vector3(0.25f, 0, 0);
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        if (Input.GetKey("d") && transform.position != player.transform.position + offset + movement)
            transform.position = player.transform.position + offset + movement;
        if (Input.GetKey("a") && transform.position != player.transform.position + offset - movement)
            transform.position = player.transform.position + offset - movement;
    }
}
