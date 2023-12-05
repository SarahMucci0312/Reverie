using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //Variables
    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private bool canSpawn = true;
    public float spawnRate = 5f;

    //Timer
    public float timeRemaining = 40;
    public bool timerIsRunning = false;

    //Begin Timer & Spawner
    private void Start()
    {
        timerIsRunning = true;
        StartCoroutine(Spawner());   
    }

    //Update time
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    //Spawn random enemy from array of prefabs
    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate); //spawn new enemy every x amount of seconds
        while (canSpawn)
        {
            yield return wait;
            int rand = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[rand];

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);

            //Stop spawning when the timer is up
            if(timeRemaining <= 0)
            {
                canSpawn = false;
            }
        }
    }
}
