using System.Collections;
using UnityEngine;

public class wendigoScreamCooldown : MonoBehaviour
{
    public bool wendigoScream;
    public AudioSource wendigoScreamAudioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(wendigoScreamWait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator wendigoScreamWait()
    {
        while (wendigoScream)
        {
            yield return new WaitForSeconds(40);
            wendigoScreamAudioSource.Play();
            yield return new WaitForSeconds(60);
        }
    }

}
