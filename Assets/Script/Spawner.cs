using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float _spawnTime = 0.1f;

    private float spawnTime { get { return _spawnTime; } }

    private float currentSpawnTime { get; set; } = 0;

    public GameObject _ennemyPrefab = null;

    private GameObject ennemyPrefab { get { return _ennemyPrefab; } }



    private void Start()
    {
        InvokeRepeating("Spawn", 0, spawnTime);
    }

    private void Spawn()
    {
        Vector3 randomPos = transform.position;
        randomPos.z += Random.Range(-3.0f, 3.0f);

        Instantiate(ennemyPrefab, transform.position, transform.rotation);
    }

    
}
