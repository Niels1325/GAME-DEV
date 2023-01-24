using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;


    void Start() {
        transform.position = player.transform.position + new Vector3(0, 10, -5);
    }


    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position + new Vector3(0, 1, -5);
    }
}