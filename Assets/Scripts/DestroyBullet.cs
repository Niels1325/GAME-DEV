using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{

    public GameObject Bullet;
    private void OnCollisionEnter (Collision collision) {
                  Destroy (gameObject);
    }
}
