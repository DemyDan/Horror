using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ScarePlayer : MonoBehaviour {

    NavMeshAgent agent;

    // The target marker.
    public Transform target;
    public GameObject lamps;
    public GameObject flash;
    public GameObject houseLamp;

    // Speed in units per sec.
    public float speed;

    public bool isHit = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (isHit == true)
        {
            agent.SetDestination(target.position);
            transform.rotation = Quaternion.LookRotation(transform.position - target.transform.position);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            isHit = true;
        }
    }

    private void OnDestroy()
    {
        lamps.SetActive(false);
        flash.SetActive(false);
        houseLamp.SetActive(true);
    }
}
