using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints = new List<SpawnPoint>();
    private int _currentEnemyCount;

    public void StartSpawning()
    {
        _spawnPoints[_currentEnemyCount].SpawnEnemy();
        _currentEnemyCount++;
        ChangeSpawnPoint();
    }

    private void ChangeSpawnPoint()
    {
        if (_currentEnemyCount == _spawnPoints.Count)
            _currentEnemyCount = 0;
    }
}