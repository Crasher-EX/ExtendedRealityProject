using UnityEngine;

public class FlameInteract : MonoBehaviour, IInteractable
{
    public bool lighterOn;
    public Animator Animator;
    public GameObject FlameObject;

    public void Update()
    {
        Animator.SetBool("lighterOn", lighterOn);
    }


    public void InteractStart(VRControllerInteraction controller)
    {
        Debug.Log("Interacted");
        controller.InteractFinish(false);

        Interact();
    }
    public void Interact()
    {
        if (lighterOn) //Turns flame off
        {
            lighterOn = false;
            FlameObject.SetActive(false);
        }
        else //Turns flame on
        {
            lighterOn= true;
            FlameObject.SetActive(true);
        }

    }
    public void InteractEnd()
    {

    }
}
