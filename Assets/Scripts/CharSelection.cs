using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelection : MonoBehaviour
{
    public GameObject toRotate;
    public GameObject player;
    public float rotateSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        player = GameObject.FindGameObjectWithTag("Santa");
        toRotate.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
