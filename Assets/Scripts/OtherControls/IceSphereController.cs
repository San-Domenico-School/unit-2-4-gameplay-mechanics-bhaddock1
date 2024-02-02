using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSphereController : MonoBehaviour
{
    [SerializeField] private float startDelay, reductionEachRepeat, minimumVolume;
    private Rigidbody iceRB;
    private ParticleSystem iceVFX;
    private float pushForce;

    /***********************************************
     * component of ice sphere
     * 
     * Bryce Haddock, 1/23/24
     * *********************************************/

    // Start is called before the first frame update
    private void Start()
    {
        if(GameManager.Instance.debugSpawnWaves)
        {
            reductionEachRepeat = 0.5f;
        }

        iceRB = GetComponent<Rigidbody>();
        iceVFX = GetComponent<ParticleSystem>();
        RandomizeSizeAndMass();
        InvokeRepeating("Melt", startDelay, 0.4f);
    }

    // Update is called once per frame
    private void RandomizeSizeAndMass()
    {
        transform.localScale *= 0.5f * Random.value + 0.5f;
    }

    private void Dissolution()
    {
        
        float Volume = 4f / 3f * Mathf.PI * Mathf.Pow(transform.localScale.x, 3);
        int numOfObjectsInScene = FindObjectsOfType<IceSphereController>().Length;
        if(numOfObjectsInScene > 1 && Volume < 0.8f)
        {
            //iceVFX.Stop();
        }

        if(Volume < minimumVolume)
        {
            Destroy(gameObject);
        }

        

    }

    private void Melt()
    {
        
        
            transform.localScale *= reductionEachRepeat;
            Dissolution();
        
    }
}
