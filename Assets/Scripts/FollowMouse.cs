using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 mousePosition;
    public float moveSpeed = 1f;

    Rigidbody rb;
    Vector3 position = new Vector3(0f,0f,0f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x,Input.mousePosition.y, Camera.main.transform.position.z-transform.position.z));
        transform.LookAt (mousePos);
    }


}
