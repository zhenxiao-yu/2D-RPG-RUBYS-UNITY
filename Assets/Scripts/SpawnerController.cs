using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private float _minSpawnTime;


    [SerializeField]
    private float _maxSpawnTime;


    private float _timeUntilNextSpawn;

    void Awake()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        _timeUntilNextSpawn -= Time.deltaTime;

        if (_timeUntilNextSpawn <= 0 ) {
           Instantiate(_enemyPrefab, transform.position, Quaternion.identity); //no rotation
           //reset timer 
           SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn() {
        _timeUntilNextSpawn = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
}
