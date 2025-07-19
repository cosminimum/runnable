using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject bossPrefab;
    public float minSpawnTime = 30f;
    public float maxSpawnTime = 60f;

    private float timer;
    private float targetTime;

    void Start()
    {
        SetNextSpawn();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= targetTime)
        {
            SpawnBoss();
            SetNextSpawn();
        }
    }

    void SetNextSpawn()
    {
        timer = 0f;
        targetTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void SpawnBoss()
    {
        if (bossPrefab != null)
        {
            Instantiate(bossPrefab, transform.position, transform.rotation);
        }
    }
}
