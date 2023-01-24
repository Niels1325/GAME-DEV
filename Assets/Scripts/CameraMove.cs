 using UnityEngine;
 using System.Collections;
 
 public class CameraMove : MonoBehaviour {
 
 
     // VARIABLES
     public float panSpeed = 4.0f;
 
     private Vector3 mouseOrigin;
     private bool isPanning;
 
     // Update is called once per frame
     void Update ()
     {
            
          if (Input.GetMouseButtonDown (1)) 
          {
              //right click was pressed    
              mouseOrigin = Input.mousePosition;
              isPanning = true;
          }
 
 
         // cancel on button release
         if (!Input.GetMouseButton (1)) 
         {
             isPanning = false;
         }
 
         //move camera on X & Y
         if (isPanning) 
         {
            Vector3 pos     = Camera.main.ScreenToViewportPoint (Input.mousePosition - Input.mousePosition);
 
             // update x and y but not z
             Vector3 move     = new Vector3 (pos.x * panSpeed, pos.y * panSpeed, 0);
 
             Camera.main.transform.Translate (move, Space.Self);
         }
     }
 }