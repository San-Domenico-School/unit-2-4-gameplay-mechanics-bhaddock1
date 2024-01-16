using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private SphereCollider playerCollider;
    private Light powerUpIndicator;
    private PlayerInputActions inputAction;
    private Transform focalpoint;
    private float moveForceMagnitude;
    private float moveDirection;
    public bool hasPowerUp { get; set; }


    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }
    private void Awake()
    {

    }
    private void OnEnable()
    {

    }
    private void OnDisable()
    {

    }
    private void OnMovementPerformed(InputAction.CallbackContext value)
    {

    }
    private void OnMovementCanceled(InputAction.CallbackContext value)
    {

    }
    private void AssignLevelValues()
    {

    }
    private void Move()
    {
        
    }
    private void OnColliderEnter(Collision collision)
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    private IEnumerator PowerUpCooldown(float cooldown)
    {
        return null;
    }
}
