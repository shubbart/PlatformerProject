using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public GameObject player;
    public GameObject bullet;
    public float range = 15.0f;
    private float dist;
    public float fireRate = 2;
    private float Timer;
    // Use this for initialization
    void Start()
    {
        Timer = fireRate;
    }

    private void Attack()
    {
        Timer = fireRate;
        GameObject obj = Instantiate(bullet, transform.position + new Vector3(0, 0, 0), bullet.transform.rotation);        
        obj.GetComponent<Rigidbody>().AddForce(transform.right * 10, ForceMode.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        dist = Vector2.Distance(transform.position, player.transform.position);
        if (dist <= range && Timer <= 0)
        {
            Attack();
        }
    }
}
