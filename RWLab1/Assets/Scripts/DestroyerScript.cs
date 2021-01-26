using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    Transform initialTransform;
    Transform boat;
    private void Start()
    {
        initialTransform = this.transform;
        boat = GameObject.FindGameObjectWithTag("Boat").transform;
    }
    void Update()
    {
        transform.position = new Vector3(boat.position.x - 3000, initialTransform.position.y, initialTransform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
