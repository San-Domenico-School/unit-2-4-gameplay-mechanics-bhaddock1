using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/*************************************************
 * component of ice sphere
 * 
 * Bryce Haddock, 1/23/24
 * ***********************************************/

public class MoveToTarget : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;
    private GameObject target;
    private Rigidbody targetRb;
    // Start is called before the first frame update
    private void Start()
    {
        target = GameObject.Find("Player");
        targetRb = target.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveTowardTarget();
    }

    private void MoveTowardTarget()
    {
        navMeshAgent.SetDestination(targetRb.transform.position);
    }
}
