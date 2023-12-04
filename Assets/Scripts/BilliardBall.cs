using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardBall : MonoBehaviour
{
    //public static ball1

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball1"))
        {

        }

        if (other.gameObject.CompareTag("Ball2"))
        {

        }

        if (other.gameObject.CompareTag("Ball3"))
        {

        }

        if (other.gameObject.CompareTag("Ball4"))
        {

        }
    }
}
