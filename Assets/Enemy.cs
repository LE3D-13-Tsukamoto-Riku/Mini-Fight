using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    GameObject playerObject;
    // Start is called before the first frame update
    [SerializeField] private Transform target;
    NavMeshAgent agent;
    float moveSpeed;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        moveSpeed = agent.speed;
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > 7.0f)
        {
            agent.destination = target.position;
            agent.speed = moveSpeed;
            agent.transform.LookAt(target.transform);
        }
        else if (Vector3.Distance(transform.position, target.position) < 7.0f)
        {
            agent.destination -= target.position;
            agent.speed = moveSpeed;
            agent.transform.LookAt(target.transform);
        }
        else
        {
            agent.speed = 0;
        }
    }
}

