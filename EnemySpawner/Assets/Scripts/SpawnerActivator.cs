using System.Collections.Generic;
using UnityEngine;

public class SpawnerActivator : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawnPoints = new List<Spawner>();
    private int _currentEnemyCount;

    public void StartSpawning()
    {
        _spawnPoints[_currentEnemyCount].SpawnEnemy();
        _currentEnemyCount++;
        ChangeSpawner();
    }

    private void ChangeSpawner()
    {
        if (_currentEnemyCount == _spawnPoints.Count)
            _currentEnemyCount = 0;
    }
}