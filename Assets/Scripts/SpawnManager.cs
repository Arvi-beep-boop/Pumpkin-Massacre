using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;

    [SerializeField]
    GameObject spawnPrefab;
    [SerializeField]
    GameObject[] spawnPoints;
    [SerializeField]
    Text currentWaveText;

    float spawnTime = 1.0f;
    int currentWave;

    public int enemiesKilled; // enemies killed in current wave
    int spawnCount; // track of spawned enemies so far
    bool spawn; // shoul i spawn
    public bool suppressActions;

    void Start()
    {
        if (instance == null)
            instance = this;
        currentWave = 1;
        enemiesKilled = 0;
        spawn = true;
        suppressActions = true;
        Debug.Log("Current wave" + currentWave);
        currentWaveText.text = "Current Wave: " + currentWave.ToString();
    }

    void Update()
    {
        if(enemiesKilled >= currentWave)
        {
            currentWave++;
            if(currentWave % 5 == 0)
            {
                spawnTime = spawnTime * 0.9f;
            }
            currentWaveText.text = "Current Wave: " + currentWave.ToString();
            enemiesKilled = 0;
            spawn = true;
            Debug.Log("Current wave" + currentWave);
        }
        if (spawn)
        {
            suppressActions = true;
            Invoke("CancelSuppressedActions", 5f);
            InvokeRepeating("SpawnEnemy", 0.5f, spawnTime);
            spawn = false;
        }
        if (spawnCount >= currentWave)
        {
            CancelInvoke("SpawnEnemy");
            spawnCount = 0;
        }
    }

    void SpawnEnemy()
    {
        int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        Instantiate(spawnPrefab, spawnPoints[randomSpawnPoint].transform.position, spawnPoints[randomSpawnPoint].transform.rotation);
        spawnCount++;
    }
    void CancelSuppressedActions()
    {
        suppressActions = false;
    }
    public int GetCurrentWave()
    { return currentWave; }
}
