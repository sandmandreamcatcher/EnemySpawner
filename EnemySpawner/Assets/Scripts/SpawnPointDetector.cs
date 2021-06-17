using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointDetector : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawnPoints = new List<Spawner>();
    private int _currentEnemyCount;

    private void Start()
    {

    }

    public void ChooseSpawnPoint()
    {
        _spawnPoints[_currentEnemyCount].SpawnEnemy();
        _currentEnemyCount++;

        if (_currentEnemyCount == _spawnPoints.Count)
            _currentEnemyCount = 0;
    }
}