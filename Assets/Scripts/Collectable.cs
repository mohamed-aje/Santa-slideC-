using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] float spinSpeed;

    private void OnTriggerEnter(Collider other)
    {

        // Destroy object if spawned inside of an object
        if (other.gameObject.GetComponent<Obstacle>())
        {
            Destroy(gameObject);
            return;
        }
        // Check when collided with the player
        
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreScript.scoreValue += 10;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, spinSpeed, 0 ,Space.World);
    }
}
