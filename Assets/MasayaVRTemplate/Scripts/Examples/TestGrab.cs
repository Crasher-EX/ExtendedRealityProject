using UnityEngine;

public class TestGrab : MonoBehaviour, IGrabbable
{
    VRControllerGrab currentController;
    public bool gravityOn;
    public GameObject model;



    public void GrabStart(VRControllerGrab controller)
    {
        Debug.Log("Grab Start");

        model.GetComponent<Rigidbody>().isKinematic = true;

        if (currentController != null)
        {
            if(currentController != controller)
            {
                currentController.GrabEnd();
                currentController = controller;
                ParentObject();
            }
        }
        else
        {
            currentController = controller;
            ParentObject();
        }
    }

    void ParentObject()
    {
        transform.parent = currentController.transform;
    }

    public void GrabEnd()
    {
        transform.parent = null;
        currentController.GrabGone(true, transform);

        currentController = null;

        model.GetComponent<Rigidbody>().isKinematic = false;
    }
}
