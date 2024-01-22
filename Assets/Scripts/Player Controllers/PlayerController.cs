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
        inputAction = new PlayerInputActions();
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
        moveDirection = 0.0f;
    }
    private void AssignLevelValues()
    {
        transform.localScale = GameManager.Instance.playerScale;
        moveForceMagnitude = GameManager.Instance.playerMoveForce;
        playerRB.drag = GameManager.Instance.playerDrag;
        playerRB.mass = GameManager.Instance.playerMass;
        focalpoint = GameObject.Find("FocalPoint").transform;
        
    }
    private void Move()
    {
        if(focalpoint != null)
        {
            playerRB.AddForce(focalpoint.forward * moveForceMagnitude * moveDirection);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Startup"))
        {
            Debug.Log("here");
            collision.gameObject.tag = "Ground";

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
        yield return null;
    }
}
