using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
    public int RoundCount = 5;
    public float timeBetweenRounds = 3;
    public int SpawnArea = 5;
    public List<GameObject> prefabs;

    [Header("DEBUG")]
    public float currentTime = 0f;
    public int currentRound = 0;

    public void Spawner()
    {

        currentTime += Time.captureDeltaTime;
        if (currentTime >= timeBetweenRounds)
        {
            ObjetGeneration();
            currentTime = 0f;
            currentRound++;
        }

       if (currentRound >= RoundCount)
        {
            //Reinciar el conteo de rondas
            currentRound = 0;
            // Ajustamos la frecuencia
            timeBetweenRounds *= 0.9f;
        }
    }


    public void ObjetGeneration()
    {


        Vector3 SpawnPosition = new Vector3(Random.Range(-SpawnArea, SpawnArea),
                                            Random.Range(-SpawnArea, SpawnArea),
                                            0);

        GameObject obj = prefabs[Random.Range(0, prefabs.Count)];
        GameObject clone = Instantiate(obj, SpawnPosition, Quaternion.identity);
        clone.transform.parent = transform;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawner();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(-SpawnArea, SpawnArea, 0));
    }
}
