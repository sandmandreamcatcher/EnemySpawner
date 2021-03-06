using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [Range(0, 10)] [SerializeField] private int _maximumEnemyCount;
    [SerializeField] private GameObject _enemyTemplate;
    private List<GameObject> _enemies = new List<GameObject>();
    private int _currentEnemyCount;

    private void Start()
    {
        for (int i = 0; i < _maximumEnemyCount; i++)
        {
            _enemies.Add(_enemyTemplate as GameObject);
        }
    }

    public void SpawnEnemy()
    {
        int number = 0;
        if (number >= 0 && number < _enemies.Count && _currentEnemyCount < _maximumEnemyCount)
        {       
            Instantiate(_enemies[number]);
            _currentEnemyCount++;
            number++;
        }
    }
}