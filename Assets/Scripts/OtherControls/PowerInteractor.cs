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
        iceSphereRb = GetComponent<Rigidbody>();
        iceSphereController = GetComponent<IceSphereController>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameObject player = collision.gameObject;
            Rigidbody playerRb = player.GetComponent<Rigidbody>();
            PlayerController playerController = player.GetComponent<PlayerController>();
            Vector3 direction = (player.transform.position - transform.position).normalized;
            if (player.GetComponent<PlayerController>().hasPowerUp)
            {
                iceSphereRb.AddForce(-direction * playerRb.mass * GameManager.Instance.playerRepelForce, ForceMode.Impulse);
            }
            else
            {
                playerRb.AddForce(direction, ForceMode.Impulse);
            }
                    
               

            
        }
    }
}
