using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleThrow : MonoBehaviour
{
    public static bool collisionWithElectricity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Electricity"))
        {
            collisionWithElectricity = true;
        }
    }
}
