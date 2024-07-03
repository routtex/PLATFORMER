using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    [SerializeField] private float _moveSpeed;
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var horizontalDirection = Input.GetAxis(Horizontal);
        var verticalDirection = Input.GetAxis(Vertical);
        transform.Translate(horizontalDirection * _moveSpeed * Vector2.right);
        transform.Translate(verticalDirection * _moveSpeed * Vector2.up);
    }
}
