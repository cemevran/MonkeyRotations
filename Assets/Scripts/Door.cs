using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool _isOpen;
    public Lever _leverInstance;

    private Quaternion _targetRotation = Quaternion.Euler(0, 0, 90);

    private void Start()
    {
        //_lever = GetComponent<Lever>();
    }

    void FixedUpdate()
    {
        if (_leverInstance._isLeverLeft == true)
        {
            //transform.rotation = Quaternion.Euler(0, 0, 90);
            _targetRotation = Quaternion.Euler(0, 0, 0);
        }

        else
        {
            //transform.rotation = Quaternion.Euler(0, 0, 0);
            _targetRotation = Quaternion.Euler(0, 0, 90);
        }

        transform.rotation = Quaternion.RotateTowards(transform.rotation, _targetRotation, 180 * Time.deltaTime);
    }
}
