using System.Collections;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    public float timeToSpawn;
    public float destroyTime;

    public GameObject vehicle;
    public Transform[] points;

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        for (int i = 0; ; i++)
        {
            int randomPoint = Random.Range(0, points.Length);
            GameObject enemy = Enemy(points[randomPoint]);

            Destroy(enemy, destroyTime);

            yield return new WaitForSeconds(timeToSpawn);
        }
        
    }
    private GameObject Enemy(Transform spawnPoint)
    {
        return Instantiate(vehicle, spawnPoint.position, spawnPoint.rotation);
    }
}
