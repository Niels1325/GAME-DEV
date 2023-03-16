using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int health;
    public int attackDamage;

    public bool isDestroyed = false;

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if(atm != null)
        {
            atm.TakeDamage(attackDamage);
        }
    }

    void Update()
    {
        if(health < 1)
        {
            Destroy(this.gameObject);
            isDestroyed = true;
        }
    }
}
