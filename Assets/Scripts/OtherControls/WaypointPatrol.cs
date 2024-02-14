using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    private NavMeshAgent navMeshAgent;
    private int wayPointIndex;
    // Start is called before the first frame update
    private void Start()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        wayPointIndex = Random.Range(0, wayPoints.Length);
    }

    // Update is called once per frame
    private void Update()
    {
        MoveToNextWaypoint();
    }

    private void MoveToNextWaypoint()
    {
        navMeshAgent.SetDestination(gameObject.transform.position);
        if(navMeshAgent.remainingDistance < 0.1f && !navMeshAgent.pathPending)
        {
            
        }
    }
}
