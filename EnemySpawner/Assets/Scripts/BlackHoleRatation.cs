using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleRatation : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _rotationDirection = 1f; 

    private void Update()
    {
        _rigidbody.rotation += (_rotationSpeed * _rotationDirection) * Time.deltaTime;
    }
}
