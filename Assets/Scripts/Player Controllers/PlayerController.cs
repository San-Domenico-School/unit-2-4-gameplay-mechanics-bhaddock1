using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/**********************************************
 * Component of Player
 * 
 * Bryce Haddock, 1/17/24
 * *******************************************/

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
        DontDestroyOnLoad(gameObject);
        playerRB = GetComponent<Rigidbody>();
        playerCollider = GetComponent<SphereCollider>();
        powerUpIndicator = GetComponent<Light>();
        playerCollider.material.bounciness = 0.4f;
        powerUpIndicator.intensity = 0;

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
        GameManager.Instance.playerScale = transform.localScale;
        GameManager.Instance.playerMoveForce = moveForceMagnitude;
        GameManager.Instance.playerDrag = playerRB.drag;
        GameManager.Instance.playerMass = playerRB.mass;
        focalpoint = GameObject.Find("Focal Point").transform;
        
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
