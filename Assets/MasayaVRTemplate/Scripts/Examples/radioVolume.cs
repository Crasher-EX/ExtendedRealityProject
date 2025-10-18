using UnityEngine;
using UnityEngine.Audio;

public class radioVolume : MonoBehaviour, IInteractable
{
    
    public AudioSource AudioSource;


    public void Start()
    {
        
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
        if (AudioSource.mute == true)
        {
            AudioSource.mute = false;
        }
        else
        {
            AudioSource.mute = true;
        }
    }

    //
    public void InteractEnd()
    {

    }
}
