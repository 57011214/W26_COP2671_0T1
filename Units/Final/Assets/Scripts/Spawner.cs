using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject meteor;
    public float xMin = -100;
    public float xMax = 80;
    public float yMin = -35;
    public float yMax = 38;
    public float zMin = -100;
    public float zMax = 100;
    public int meteorCount;
    public bool gameActive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnMeteors();
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnMeteors() {
        for (int i = 0; i < 2750; i++) {
            Instantiate(meteor, FirstSpawn(), Quaternion.Euler(meteor.transform.position));
        }
    }
    private Vector3 FirstSpawn() {
        float x = Random.Range(xMin, xMax);
        float y = Random.Range(yMin, yMax);
        float z = Random.Range(zMin, zMax);

        Vector3 randomPos = new Vector3(x, y, z);

        return randomPos;
    }
    private Vector3 GenerateSpawnPosition() 
    {
        float x = -100;
        float y = Random.Range(yMin, yMax);
        float z = Random.Range(zMin, zMax);

        Vector3 randomPos = new Vector3(x, y, z);

        return randomPos;
    }

    IEnumerator Spawn() {
        while(gameActive) {
            Instantiate(meteor, GenerateSpawnPosition(), Quaternion.Euler(meteor.transform.position));
            Instantiate(meteor, GenerateSpawnPosition(), Quaternion.Euler(meteor.transform.position));
            Instantiate(meteor, GenerateSpawnPosition(), Quaternion.Euler(meteor.transform.position));
            Instantiate(meteor, GenerateSpawnPosition(), Quaternion.Euler(meteor.transform.position));
            Instantiate(meteor, GenerateSpawnPosition(), Quaternion.Euler(meteor.transform.position));

            yield return null;
        }
    }
}
