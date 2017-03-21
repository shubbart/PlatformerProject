using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    public GameObject player;
    void Update ()
    {
        transform.right = player.transform.position - transform.position;
    }
}
