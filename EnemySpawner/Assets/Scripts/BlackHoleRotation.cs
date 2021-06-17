using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleRotation : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody = null;
    [SerializeField] private float _rotationSpeed = 40f;
    [SerializeField] private float _rotationDirection = 1f; 

    private void Awake()
    {
        _rigidbody.GetComponentsInParent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.rotation += (_rotationSpeed * _rotationDirection) * Time.fixedDeltaTime;
    }
}
