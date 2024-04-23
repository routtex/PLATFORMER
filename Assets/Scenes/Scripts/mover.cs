using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] private Vector2 _movementDirection;
    private void Update()
    {
        transform.Translate(_movementDirection);
    }
}
