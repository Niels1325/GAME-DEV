using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 200f;
    private Vector3 aim;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            Shoot();
        }

        Camera cam = Camera.main;
 
        Vector3 mousePos = Input.mousePosition;
        aim = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
    }

    void Shoot() 
    {
        firePoint.transform.LookAt(aim);
        var instance = Instantiate(bulletPrefab, firePoint.transform.position, firePoint.rotation);
        instance.transform.LookAt(aim);
        //rb = GetComponent<Rigidbody>();
        instance.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * bulletForce, ForceMode.Impulse);
    }
}
