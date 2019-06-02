using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_point : MonoBehaviour
{
    public GameObject _prefab;
    public float _speed;
    private Rigidbody _rigidbody;

    void Start()
    {
       
    }
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            GameObject _bull = Instantiate(_prefab, transform.position, Quaternion.identity);
            Rigidbody _rigidbody = _bull.GetComponent<Rigidbody>();

            _rigidbody.velocity = _speed * transform.forward;

            Destroy(_bull, 5F);
        } 
    }
}
