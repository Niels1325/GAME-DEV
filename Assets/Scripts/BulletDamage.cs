using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public AttributesManager zombieAtm;
    public GameObject Zombie;
    public AttributesManager bulletAtm;
    public GameObject Bullet;

        public void OnCollisionEnter (Collision collision) {
        //if(collision.gameObject.tag == "Zombie")
            //bulletAtm.DealDamage(zombieAtm.gameObject);
            zombieAtm.TakeDamage(33);
    }
}

