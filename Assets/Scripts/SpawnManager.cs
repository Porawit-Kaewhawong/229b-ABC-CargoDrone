using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject enemyPrefab;

    public int totalEnemy;
    public float spawnTimeInterval = 1f;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(2f);

        int enemyCount = totalEnemy;

        while (enemyCount > 0)
        {
            yield return new WaitForSeconds(1f);
            SpawnEnemy();
            enemyCount--;
        }
    }

    void SpawnEnemy()
    {
        var index = Random.Range(0, spawnPoints.Length);
        var spawn = spawnPoints[index];

        Instantiate(enemyPrefab, spawn.transform.position, Quaternion.identity);
    }

    void Update()
    {

    }
}
