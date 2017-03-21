using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IDamage, IHeal
{
    public GameObject self;
    public float healthValue;
    public float armorValue;
    public float healingMultiplier;

    public Health() : this(100, 3.0f) { }

    public Health(float startHealth) : this(startHealth, 3.0f) { }

    public Health(float startHealth, float startArmor)
    {
        healthValue = startHealth;
        armorValue = startArmor;
    }

    public float EstimatedDamageTaken(float damageDealt)
    {
        return damageDealt - armorValue;
    }
    public void TakeDamage(float damageDealt)
    {
        float dmg = EstimatedDamageTaken(damageDealt);
        if (dmg <= 0)
            return;
        healthValue -= dmg;
    }

    public float EstimatedHealingReceived(float healing)
    {
        return healing * healingMultiplier;
    }
    public void TakeHealing(float healing)
    {
        healthValue += EstimatedHealingReceived(healing);
    }


    void Death()
    {
        DestroyObject(self);
    }
    void Update()
    {
        if (healthValue <= 0)
            Death();
    }
}
