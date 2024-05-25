using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Vector3 _offset;

    private Car _car;

    public void Start()
    {
        _car = FindFirstObjectByType<Car>();
        transform.position = _car.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = _car.transform.position + _offset;
    }
}
