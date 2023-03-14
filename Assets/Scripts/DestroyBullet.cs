using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{

    public GameObject Bullet;

    public void OnCollisionEnter (Collision collision) {
            Destroy (gameObject);           
    }
}
