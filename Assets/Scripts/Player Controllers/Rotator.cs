using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/***********************************************
 * Component of Focal Point
 * 
 * Bryce Haddock, 1/17/24
 * ********************************************/

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private PlayerInputActions inputAction;
    private float moveDirection;

    private void Awake()
    {
        inputAction = new PlayerInputActions();
    }
    private void Update()
    {
        transform.Rotate(Vector3.up, moveDirection * rotationSpeed * Time.deltaTime);
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

        moveDirection = value.ReadValue<Vector2>().x;
    }
    private void OnMovementCanceled(InputAction.CallbackContext value)
    {
        moveDirection = 0.0f;
    }
    
}
