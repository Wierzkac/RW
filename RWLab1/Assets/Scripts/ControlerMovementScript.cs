using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerMovementScript : MonoBehaviour
{
    public bool isInWater = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            isInWater = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            isInWater = false;
        }
    }
}
