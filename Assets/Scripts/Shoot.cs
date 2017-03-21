using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float damage;
    public float lifeTime = 1.5f;
    
    void OnCollisionEnter(Collision other)
    {

        IDamage target = other.gameObject.GetComponent<IDamage>();
        target.TakeDamage(damage);
        DestroyObject(bullet);

    }
	void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
            DestroyObject(bullet);
    }
}
