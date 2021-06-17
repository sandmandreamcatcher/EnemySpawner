using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [Range(0, 10)] [SerializeField] private float _timerCheckpoint = 2f;
    [SerializeField] private float _currentTimerValue = 0;
    [SerializeField] private UnityEvent _timeHasCome;

    private bool _timerIsRunning = false;
    public bool TimerExpired => _timerIsRunning;

    private void Update()
    {
        if (_currentTimerValue < _timerCheckpoint)
        {
            _timerIsRunning = false;
            _currentTimerValue += Time.deltaTime;         
        }
        else
        {
            _timerIsRunning = true;
            _timeHasCome?.Invoke();
            _currentTimerValue = 0;
        }
    }
}