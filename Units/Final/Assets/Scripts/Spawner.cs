using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject meteor;
    public float randomXRange = 70;
    public float randomYRange = 65;
    public float randomZRange = 70;

    public int meteorCount;
    public int spawnRate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnMeteors();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnMeteors() {
        for (int i = 0; i < spawnRate; i++) {
            Instantiate(meteor, GenerateSpawnPosition(), Quaternion.Euler(meteor.transform.position));
        }
    }
    private Vector3 GenerateSpawnPosition() 
    {
        float spawnPosX = Random.Range(-randomXRange, randomXRange);
        float spawnPosY = Random.Range(0, randomYRange);
        float spawnPosZ = Random.Range(-randomZRange, randomZRange);

        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

        return randomPos;
    }
}
