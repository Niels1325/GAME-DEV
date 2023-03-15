using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public AttributesManager zombieAtm;
    public AttributesManager bulletAtm;
    public AttributesManager playerAtm;
    public GameObject bullet;

    void OnCollisionEnter(Collision coll)
    { 
        if(coll.gameObject.tag == "bullet")
        {
            bulletAtm.DealDamage(zombieAtm.gameObject);
            Debug.Log("Zomie HP: " + zombieAtm.health);
        }  else
        {
            Debug.Log(coll + " test");
        }
    }
    void OnCollisionStay(Collision coll)
    {
        if (coll.gameObject.tag == "player")
        {
            zombieAtm.DealDamage(playerAtm.gameObject);
            Debug.Log(" Player -10 " + "Current Player HP: " + playerAtm.health);
        }
    }
}
