using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**************************************************
 * Component of game manager
 * 
 * 
 * Bryce Haddock,  1/17/24
 * ***********************************************/

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Player Fields")]
    public Vector3 playerScale;
    public float playerMass, playerDrag, playerMoveForce, playerRepelForce, playerBounce;

    [Header("Scene Fields")]
    public GameObject[] wayPoints;

    [Header("Debug Fields")]
    public bool debugSpawnWaves, debugSpawnPortal, debugSpawnPowerUp, debugPowerUpRepel;

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
        if(Instance == null)
        {
            Instance = this;
        }
        if(!Instance != this)
        {
            Destroy(this);
        }
    }
    private void EnablePlayer()
    {

    }
    private void SwitchLevels()
    {

    }
}

