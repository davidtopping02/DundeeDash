using UnityEngine;

public class GroundGenerator : MonoBehaviour
{

    public GameObject GroundTile;
    Vector3 nextSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            spawnTile();
        }
    }

    // Spawns the next tile in the path
    public void spawnTile()
    {
        // instantiate new tile in the next spawn point with the same rotation 
        GameObject tile = Instantiate(GroundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = tile.transform.GetChild(1).transform.position;
    }

}
