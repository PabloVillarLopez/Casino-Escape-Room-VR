using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActivation : MonoBehaviour
{
    public GameObject introCinematicCamera;
    public GameObject vrCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateVRCamera()
    {
        vrCamera.SetActive(true);
        introCinematicCamera.SetActive(false);
    }

    public void ActivateIntroCamera()
    {
        vrCamera.SetActive(false);
        introCinematicCamera.SetActive(true);
    }
}
