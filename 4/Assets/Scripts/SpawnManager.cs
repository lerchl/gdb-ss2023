using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private int waveNumber = 1;
    private readonly float spawnRange = 9;

    // /////////////////////////////////////////////////////////////////////////
    // Methods
    // /////////////////////////////////////////////////////////////////////////

    void Update() {
        if (FindObjectsOfType<Enemy>().Length == 0) {
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
            SpawnEnemyWave(waveNumber++);
        }
    }

    private void SpawnEnemyWave(int enemiesToSpawn) {
        for (int i = 0; i < enemiesToSpawn; i++) {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition() {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        return new (spawnPosX, 0, spawnPosZ);
    }
}
