using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private Vector3 _currentPosition;

    void Update()
    {
        _currentPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        _currentPosition.z = 0f;
        transform.position = _currentPosition;
    }
}
