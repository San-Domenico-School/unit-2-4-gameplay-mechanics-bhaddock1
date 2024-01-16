using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player Fields")]
    public Vector3 playerScale;
    public float playerMass, playerDrag, playerMoveForce, playerRepelForce, playerBounce;

    [Header("Scene Fields")]
    public GameObject[] wayPoints;

    [Header("Debug Fields")]
    public bool debugSpawnWolves, debugSpawnPortal, debugSpawnPowerUp, debugPowerUpRepel;

    public bool switchLevels { get; set;  }
    public bool gameOver { get; set; }
    public bool playerHasPowerUp { get; set; }



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
    private void EnablePlayer()
    {

    }
    private void SwitchLevels()
    {

    }
}

