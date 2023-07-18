using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 180;
    void FixedUpdate()
    {
        transform.Rotate(0, 0, _moveSpeed * Time.deltaTime);
    }
}
