using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject zombie;
    public AttributesManager zombieAtm;
    public float zombieCount = 10;
    public float killCount = 0;

    GameObject[] zombies = GameObject.FindGameObjectsWithTag("zombie");
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(zombies.Length < 0.5f)
        {
            killCount =+ 10;
            Debug.Log(killCount);
            Debug.Log("test");
        } else
        {
            Debug.Log("er gaat iets fout");
        }
    }
}
