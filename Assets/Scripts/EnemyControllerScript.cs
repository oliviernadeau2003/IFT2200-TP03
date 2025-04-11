using UnityEngine;

public class EnemyControllerScript : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab of the enemy to spawn
    public Transform spawnPoint; // Point where the enemy will spawn

    private void Start()
    {
        SpawnEnemy();
    }

    void Update()
    {
        
    }

    private void SpawnEnemy()
    {
        // Instantiate the enemy prefab at the spawn point
        GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

        // Set the enemy's parent to this object
        enemy.transform.parent = transform;
        enemy.SetActive(true);
    }


}
