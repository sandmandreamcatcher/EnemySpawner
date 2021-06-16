using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleRotation : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _rotationDirection = 1f; 

    private void FixedUpdate()
    {
        _rigidbody.rotation += (_rotationSpeed * _rotationDirection) * Time.deltaTime;
    }
}
