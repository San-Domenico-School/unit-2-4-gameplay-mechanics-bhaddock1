using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    private GameObject[] waypoints;
    private NavMeshAgent navMeshAgent;
    private int wayPointIndex;
    // Start is called before the first frame update
    private void Start()
    {
        waypoints = GameManager.Instance.waypoints;
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        wayPointIndex = Random.Range(0, waypoints.Length);
    }

    // Update is called once per frame
    private void Update()
    {
        MoveToNextWaypoint();
    }

    private void MoveToNextWaypoint()
    {
        navMeshAgent.SetDestination(waypoints[wayPointIndex].transform.position);
        if(navMeshAgent.remainingDistance < 3f && wayPointIndex < 15 && !navMeshAgent.pathPending)
        {
            wayPointIndex = ++wayPointIndex;
        }
    }
}
