using UnityEngine;

public class GroundTile : MonoBehaviour
{


    GroundSpawner groundSpawner;

    
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            groundSpawner.SpawnTile(true);
            Destroy(gameObject, 2);
            Debug.Log("Plane removed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject obstaclePrefab;
    public void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        int obstacleDirection = Random.Range(1, 3);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        if (obstacleDirection == 1)
        {
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.Euler(-90, 0, 0), transform);
        }
        if (obstacleDirection == 2)
        {
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.Euler(-90, -180, 0), transform);
        }

    }
    public GameObject presentPrefab;
    public GameObject fencePrefab;

    // Use random position to spawn collectable on the tiles
    public void SpawnCollectable()
    {
        int presentsToSpawn = 1;
        for (int i = 0; i < presentsToSpawn; i++)
        {
            GameObject temp = Instantiate(presentPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }
    
    // Get random position for the collectable to spawn to
    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            0,
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }
        point.y = 1;
        return point;
    }
    public int fenceHeightOffset = 1;
    public GameObject fenceColliderPrefabLeft;
    public GameObject fenceColliderPrefabRight;
    public void SpawnFence()
    {
        var positionLeft = new Vector3(-5.8f, transform.position.y + fenceHeightOffset, transform.position.z);
        var colPositionLeft = new Vector3(-5.7f, transform.position.y + fenceHeightOffset, transform.position.z);

        Instantiate(fencePrefab, positionLeft, Quaternion.Euler(new Vector3(-90, -90, 0)), transform);
        

        Instantiate(fenceColliderPrefabLeft, colPositionLeft, Quaternion.Euler(new Vector3(-90, -90, 0)), transform);

        var positionRight = new Vector3(5.8f, transform.position.y + fenceHeightOffset, transform.position.z);
        var colPositionRight = new Vector3(5.7f, transform.position.y + fenceHeightOffset, transform.position.z);

        Instantiate(fencePrefab, positionRight, Quaternion.Euler( new Vector3(-90,90,0)), transform);

        Instantiate(fenceColliderPrefabRight, colPositionRight, Quaternion.Euler(new Vector3(-90, 90, 0)), transform);
    }
   
}
