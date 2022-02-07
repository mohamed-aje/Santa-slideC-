using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftColliderScript : MonoBehaviour
{
    public GameObject santa;
    // Start is called before the first frame update
    void Start()
    {
        santa = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Santa collided with the left fence");
            santa.transform.position = new Vector3(-4.2f, santa.transform.position.y, santa.transform.position.z);
        }
    }
}
