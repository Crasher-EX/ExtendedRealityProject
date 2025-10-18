using System.Collections;
using UnityEngine;

public class lightningFlashes : MonoBehaviour
{

    public GameObject lightningModel;
    public float waitBetweenFlash;
    public bool lightningOn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(LightningFlash());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator LightningFlash()
    {
        while (lightningOn)
        {
            
            waitBetweenFlash = Random.Range(15, 25);
            Debug.Log("Time till next lightningFlash: " + waitBetweenFlash);
            yield return new WaitForSeconds(waitBetweenFlash);

            lightningModel.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            lightningModel.SetActive(false);

            yield return new WaitForSeconds(0.2f);
            
            lightningModel.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            lightningModel.SetActive(false);
        }
    }
}
