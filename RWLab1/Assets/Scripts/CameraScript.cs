using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject boat;
    float speedH = 2f;
    float speedV = 2f;

    float yaw = 0f;
    float pitch = 0f;

    private void Start()
    {
        boat = GameObject.FindGameObjectWithTag("Boat");
    }
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch += speedV * -Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch + boat.transform.rotation.x, yaw, 0f);
    }
}
