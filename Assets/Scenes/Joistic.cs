using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joistic : MonoBehaviour
{
    [SerializeField]
    private Transform joistic;
    [SerializeField]
    private float _speed = 5F;
    private float _angel = 90F;

    // --------------------------------------------------------------------------------------------
    private void Awake()
    {
        
    }
    // --------------------------------------------------------------------------------------------
    void Start()
    {
        
    }
    // --------------------------------------------------------------------------------------------
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -_angel);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * _angel);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * Time.deltaTime * -_speed);
        }
    }
    // --------------------------------------------------------------------------------------------
    private void FixedUpdate()
    {
        
    }
    // --------------------------------------------------------------------------------------------
    private void LateUpdate()
    {
        
    }
}
