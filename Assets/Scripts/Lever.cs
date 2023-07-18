using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool _isLeverLeft = true;//Determines if the lever is currently left (=true) or right (=false)
    [SerializeField] private Transform _leverTop;

    private Quaternion _targetRotation = Quaternion.Euler(0, 0, -30);

    private void FixedUpdate()
    {
        if (_isLeverLeft)
            _targetRotation = Quaternion.Euler(0, 0, -30);
        //_leverTop.transform.rotation = Quaternion.Euler(0, 0, -30);

        else
            _targetRotation = Quaternion.Euler(0, 0, 30);
        //_leverTop.transform.rotation = Quaternion.Euler(0, 0, 30);

        _leverTop.transform.rotation = Quaternion.RotateTowards(_leverTop.transform.rotation, _targetRotation, 180 * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            _isLeverLeft = !_isLeverLeft;//if _isLeverLeft was true -> set it to false. If it was false -> set it to true

            //TODO: Set Rotations of Lever

        }
    }
}
