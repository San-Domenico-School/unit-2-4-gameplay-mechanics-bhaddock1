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
        for(int i = 0; i < waveNumber; i++)
        {
            Instantiate(iceSphere, SetRandomPosition(1.6f), iceSphere.transform.rotation);
        }
        if(waveNumber < maximumWave)
        {
            waveNumber++;
        }
    }

    private void SetObjectActive(float byWaveProbability, GameObject obj)
    {

    }

    private Vector3 SetRandomPosition(float posY)
    {
       

        float randomX = Random.Range(-islandSize.x / 2, islandSize.x / 2);
        float randomZ = Random.Range(-islandSize.z / 2, islandSize.z / 2);
        return new Vector3(randomX, posY, randomZ);
    }

    private IEnumerator CountdownTimer(string objectTag)
    {
        return null;
    }

    
}
