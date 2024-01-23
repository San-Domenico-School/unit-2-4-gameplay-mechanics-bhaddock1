using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**************************************************
 * component of ice sphere game object
 * 
 * Bryce Haddock, 1/23/24
 * ************************************************/

public class PowerInteractor : MonoBehaviour
{
    [SerializeField] private float pushForce;
    private Rigidbody iceSphereRb;
    private IceSphereController iceSphereController;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
