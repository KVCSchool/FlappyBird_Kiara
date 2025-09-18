using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    //TODO: Change to conform to expectations of teacher

    public GameObject pipe;

    public float spawnRate = 2.0f;
    private float spawnTimer = 0.0f;

    public float heightOffset = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnRate)
        {
            SpawnPipe();
            spawnTimer = 0.0f;
        }
    }

    void SpawnPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, transform.position.y + Random.Range(-heightOffset, heightOffset), transform.position.z), transform.rotation);
    }
}
