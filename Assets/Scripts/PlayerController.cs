using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    public float forwardSpeed = 20f;

    private float slowedspeed = 15f;
    public float sideSpeed = 7;

    private float maxSpeed = 50f;

    public float time;





    private void Start()
    {


        //transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime)
        //rb.MovePosition(Vector3.forward * forwardSpeed * Time.deltaTime);

        InvokeRepeating("AddForwardSpeed", 1f, 4);

    }
    Vector3 santaRotationLeft = new Vector3(0, -10, 0);
    Vector3 santaRotationRight = new Vector3(0, 10, 0);
    Vector3 santaRotationForward = new Vector3(0, 0, 0);
    private void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * sideSpeed * Time.deltaTime);
            transform.eulerAngles = santaRotationLeft;
        }
        else { transform.eulerAngles = santaRotationForward; }

        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * sideSpeed * Time.deltaTime);
            transform.eulerAngles = santaRotationRight;
        }



        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        if (forwardSpeed >= maxSpeed)
        {
            forwardSpeed = maxSpeed - 2;
        }
        
    }

    //IEnumerator SpeedUp()
    //{
    //    yield return new WaitForSecondsRealtime(timeinterval);
    //    forwardSpeed += 10;
    //    Debug.Log(forwardSpeed);
    //}

    public void AddForwardSpeed()
    {
          forwardSpeed += 2;
          Debug.Log(forwardSpeed);
    }
}