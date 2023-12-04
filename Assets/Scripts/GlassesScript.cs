using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class GlassesScript : MonoBehaviour
{
    public static bool glassesOn;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(ShowObjectsByGlasses);
        grabInteractable.selectExited.AddListener(HideObjectsByGlasses);
    }

    public void ShowObjectsByGlasses(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Glasses")
        {
            glassesOn = true;
        }
    }

    public void HideObjectsByGlasses(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Glasses")
        {
            glassesOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
