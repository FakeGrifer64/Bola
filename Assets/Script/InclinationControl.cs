using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InclinationControl : MonoBehaviour
{
    [SerializeField] private float _inclinationSpeed = 5f;

    private void Update()
    {
        float horizontal = -Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical"); 

        transform.Rotate(Vector3.forward, horizontal * Time.deltaTime * _inclinationSpeed);
        transform.Rotate(Vector3.right, vertical * Time.deltaTime * _inclinationSpeed);
    }
}
