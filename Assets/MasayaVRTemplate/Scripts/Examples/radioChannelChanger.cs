using UnityEngine;
using UnityEngine.Audio;

public class radioChannelChanger : MonoBehaviour, IInteractable
{
    public int frequencyChannel = 1;
    public AudioSource AudioSource;
    public AudioClip track1;
    public AudioClip track2;
    public AudioClip track3;
    public AudioClip track4;
    public AudioClip track5;


    public void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    public void InteractStart(VRControllerInteraction controller)
    {
        Debug.Log("Interacted");
        controller.InteractFinish(false);

        Interact();
    }

    //changing radio frequency channels
    public void Interact()
    {
        if(frequencyChannel == 1)
        {
            frequencyChannel = 2;
            AudioSource.clip = track1;
            AudioSource.Play();
        }
        else if(frequencyChannel == 2)
        {
            frequencyChannel = 3;
            AudioSource.clip = track2;
            AudioSource.Play();
        }
        else if (frequencyChannel == 3)
        {
            frequencyChannel = 4;
            AudioSource.clip = track3;
            AudioSource.Play();
        }
        else if (frequencyChannel == 4)
        {
            frequencyChannel = 5;
            AudioSource.clip = track4;
            AudioSource.Play();
        }
        else
        {
            frequencyChannel = 1;
            AudioSource.clip = track5;
            AudioSource.Play();
        }
    }

    //
    public void InteractEnd()
    {
        
    }
}
