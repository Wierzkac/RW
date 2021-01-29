using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoatMovement : MonoBehaviour
{
    [SerializeField] 
    Text ScoreText;
    [SerializeField]
    float rotationScale = 200000f;
    [SerializeField]
    float accelerationScale = 1000f;
    [SerializeField]
    GameObject paddle_left;
    [SerializeField]
    GameObject paddle_right;

    ControlerMovementScript controller_left;
    ControlerMovementScript controller_right;
    float accelerationForward = 0f;
    float accelerationSides = 0f;
    Rigidbody boatRigidbody;
    Vector3 initialPosition;
    float score;
    private void Start()
    {
        boatRigidbody = this.GetComponent<Rigidbody>();
        initialPosition = this.transform.position;
        score = 0;
        controller_left = paddle_left.GetComponent<ControlerMovementScript>();
        controller_right = paddle_right.GetComponent<ControlerMovementScript>();
    }

    void Update()
    {
        float left = 0f, right = 0f;
        if (controller_left.isInWater || Input.GetKey(KeyCode.LeftArrow))
            left = 1f;
        if (controller_right.isInWater || Input.GetKey(KeyCode.RightArrow))
            right = 1f;
        float diff = right - left;
        if (diff == 0 && left != 0f && right != 0f)
            accelerationForward = 10f * accelerationScale;
        else
            accelerationSides = diff * rotationScale;

        boatRigidbody.AddTorque(transform.up * accelerationSides);
        boatRigidbody.AddRelativeForce(new Vector3(accelerationForward, 0, 0));


        accelerationForward = 0f;
        accelerationSides = 0f;

        score = Vector3.Distance(initialPosition, this.transform.position);
        ScoreText.text = string.Format("{0:0.00}", score);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rock")
        {
            //EndGame
            PlayerPrefs.SetFloat("Score", score);
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndScreen");
        }
    }
}