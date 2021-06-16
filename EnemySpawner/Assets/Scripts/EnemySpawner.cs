using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _blackHoles = new GameObject[3];
    [SerializeField] private List<Enemy> _enemies = new List<Enemy>();
    [Range(0, 10)] [SerializeField] private float _cooldown = 2f;
    private bool _enemySpawned;

    private void Start()
    {

            Instantiate(_enemies[1]);
  
    }
}
