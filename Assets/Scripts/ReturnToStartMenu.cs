using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToStartMenu : MonoBehaviour
{
    public void ReturnToStartMenuMethod()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(0);
    }
}
