using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab del enemigo a instanciar
    public float spawnDelay = 10f; // Tiempo entre cada spawn
    private float nextSpawnTime = 0f; // Tiempo del pr�ximo spawn

    void Update()
    {
        // Si ha pasado suficiente tiempo desde el �ltimo spawn
        if (Time.time >= nextSpawnTime)
        {
            // Instanciar un enemigo en la posici�n del spawner
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);

            // Actualizar el tiempo del pr�ximo spawn
            nextSpawnTime = Time.time + spawnDelay;
        }
    }
}
