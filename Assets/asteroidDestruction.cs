using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidDestruction : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public int initialAsteroidCount = 4;
    public float respawnTime = 5f;

    private int currentAsteroidCount;

    // Start is called before the first frame update
    void Start()
    {
        currentAsteroidCount = initialAsteroidCount;
        for (int i = 0; i < initialAsteroidCount; i++)
        {
            SpawnAsteroid();
        }
    }

    public void AsteroidDestroyed()
    {
        currentAsteroidCount--;
        if (currentAsteroidCount <= 0)
        {
            StartCoroutine(RespawnAllAsteroids());
        }
    }

    private IEnumerator RespawnAllAsteroids()
    {
        yield return new WaitForSeconds(respawnTime);
        for (int i = 0; i < initialAsteroidCount; i++)
        {
            SpawnAsteroid();
        }
        currentAsteroidCount = initialAsteroidCount;
    }

    private void SpawnAsteroid()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0);
        Instantiate(asteroidPrefab, randomPosition, Quaternion.identity);
    }
}
