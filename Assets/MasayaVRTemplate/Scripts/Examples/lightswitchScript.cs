using UnityEngine;

public class lightswitchScript : MonoBehaviour, IInteractable
{
    public bool lightOn;
    public GameObject lamps;
    public GameObject lightSwitch1; //off switch
    public GameObject lightSwitch2; //on switch

    public void InteractStart(VRControllerInteraction controller)
    {
        Debug.Log("Interacted");
        controller.InteractFinish(false);

        if (lightOn == false)
        {
            Interact();
        }
        else
        {
            InteractEnd();
        }
    }

    //Turning lightswitch on, enabling wall lamps
    public void Interact()
    {
        lightOn = true;
        lamps.SetActive(true);
        lightSwitch1.SetActive(true);
        lightSwitch2.SetActive(false);
    }

    //Turning lightswitch of, disabling wall lamps
    public void InteractEnd()
    {
        lightOn = false;
        lamps.SetActive(false);
        lightSwitch1.SetActive(false);
        lightSwitch2.SetActive(true);
    }
}
