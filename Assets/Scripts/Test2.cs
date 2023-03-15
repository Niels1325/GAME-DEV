using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public AttributesManager zombieAtm;
    public AttributesManager bulletAtm;
    public GameObject bullet;

    void OnCollisionEnter(Collision coll)
    { 
        if(coll.gameObject.tag == "bullet")
        {
            bulletAtm.DealDamage(zombieAtm.gameObject);
            Debug.Log(zombieAtm.health);
        } else
        {
            Debug.Log(coll + " test");
        }
    }   
}
