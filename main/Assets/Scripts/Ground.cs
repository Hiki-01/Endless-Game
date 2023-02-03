using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    EndlessGround endlessGround;
    // Start is called before the first frame update
    
    void Start()
    {
        endlessGround = GameObject.FindObjectOfType<EndlessGround>();
        WallLooping();
        
    }
    private void OnTriggerExit(Collider other)
    {
        endlessGround.GroundMaker();

        Destroy(gameObject, 2);
            }
    public GameObject ObstaclePrefab;
    
    void WallLooping()
    {
        int ObstacleSpawnIndex = Random.Range(2, 5);
        Transform SpawnPoint = transform.GetChild(ObstacleSpawnIndex).transform;
        Instantiate(ObstaclePrefab, SpawnPoint.position, Quaternion.identity, transform);
        

    }
    
}
