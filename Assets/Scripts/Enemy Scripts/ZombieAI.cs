using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    //Variable voor NavMeshAgent (functie in Unity voor automatische beweging)
    NavMeshAgent nm;

    //Variable voor target (deze transform is dus de player)
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //Pak de component Nav Mesh Agent van de zombie en deze word nm genoemd
        nm = GetComponent<NavMeshAgent>();
        //Zet target op de player via deze tag "playertransform"
        target = GameObject.FindWithTag("playertransform").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Zet de bestemming waar de zombie heen moet lopen (dus de player)
        nm.SetDestination(target.position);
    }
}
