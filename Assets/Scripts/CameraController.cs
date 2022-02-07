using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
     private Vector3 offset;
     public Transform target;

    
    void Start()
    {
        offset = transform.position - target.position;
    }
    private void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(transform.position.x,transform.position.y,offset.z+target.position.z);
        transform.position = Vector3.Lerp(transform.position,targetPosition,10*Time.deltaTime);
    }
    

}


