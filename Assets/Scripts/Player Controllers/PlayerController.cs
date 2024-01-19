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
    private void FixedUpdate()
    {
        Move();
    }
    private void Awake()
    {

    }
    private void OnEnable()
    {
        inputAction.Enable();
        inputAction.Player.Movement.performed += OnMovementPerformed;
        inputAction.Player.Movement.canceled += OnMovementCanceled;
    }
    private void OnDisable()
    {
        inputAction.Disable();
        inputAction.Player.Movement.performed -= OnMovementPerformed;
        inputAction.Player.Movement.performed -= OnMovementCanceled;
    }
    private void OnMovementPerformed(InputAction.CallbackContext value)
    {
        moveDirection = value.ReadValue<Vector2>().y;
    }
    private void OnMovementCanceled(InputAction.CallbackContext value)
    {
        moveDirection = 0;
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
        if(focalpoint != null)
        {
            playerRB.AddForce(focalpoint.forward * moveForceMagnitude * moveDirection);
        }
    }
    private void OnColliderEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            playerCollider.material.bounciness = GameManager.Instance.playerBounce;
            AssignLevelValues();
        }
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
