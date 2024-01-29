using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************************************************
 * component of spawnManager, spawns game objects
 * 
 * Bryce, 1/29/24
 * ************************************************************/


public class SpawnManager : MonoBehaviour
{
    [Header("Objects to Spawn")]
    [SerializeField] private GameObject iceSphere, portal, powerUp;

    [Header("Wave Fields")]
    [SerializeField] private int initialWave, increaseEachWave, maximumWave;

    [Header("Portal Fields")]
    [SerializeField] private int portalFirstAppearance;
    [SerializeField] private float portalUpByWaveDuration, portalUpByWaveProbability;

    [Header("PowerUp Fields")]
    [SerializeField] private int powerUpFirstAppearance;
    [SerializeField] private float powerUpByWaveProbability, powerUpByWaveDuration;

    [Header("Island")]
    [SerializeField] private GameObject island;
    private Vector3 islandSize;
    private int waveNumber;
    private bool portalActive;
    private bool powerUpActive;
    // Start is called before the first frame update

    private void Start()
    {
        islandSize = island.GetComponent<MeshCollider>().bounds.size;

        waveNumber = 1;
    }

    // Update is called once per frame
    private void Update()
    {

        if(GameObject.Find("Player") != null && FindObjectsOfType<IceSphereController>().Length < 0)
        {
            SpawnIceWave();
        }
    }

    private void SpawnIceWave()
    {

    }

    private void SetObjectActive(float byWaveProbability, GameObject obj)
    {

    }

    private Vector3 SetRandomPosition(float posY)
    {
        return new Vector3();

        float randomX = Random.Range(-islandSize.x / 2, islandSize.x / 2);
    }

    private IEnumerator CountdownTimer(string objectTag)
    {
        return null;
    }

    
}
