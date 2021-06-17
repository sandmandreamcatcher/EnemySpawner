using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [Range(0, 10)] [SerializeField] private float _timerCheckpoint = 2f;
    [SerializeField] private UnityEvent _timeHasCome;
    private float _currentTimerValue = 0;

    private void Update()
    {
        if (_currentTimerValue < _timerCheckpoint)
        {
            _currentTimerValue += Time.deltaTime;         
        }
        else
        {
            _timeHasCome?.Invoke();
            _currentTimerValue = 0;
        }
    }
}