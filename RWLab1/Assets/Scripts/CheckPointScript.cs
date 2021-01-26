using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointScript : MonoBehaviour
{
    [SerializeField]
    GameObject terrain;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boat")
        {
            Instantiate(terrain, new Vector3(terrain.transform.position.x + 995, terrain.transform.position.y, terrain.transform.position.z), new Quaternion(terrain.transform.rotation.x, terrain.transform.rotation.y, terrain.transform.rotation.z, terrain.transform.rotation.w));
        }
    }
}
