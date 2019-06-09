using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private GameObject _playerTarget;
    public float _movespeed;
    public float _rotateSpeed;

    void Start()
    {
        _playerTarget = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        Vector3 _dir = (_playerTarget.transform.position - transform.position).normalized;
        Vector3 _newdir = Vector3.RotateTowards(transform.forward, _dir, _rotateSpeed * Time.deltaTime, 0.0F);

        transform.position += _dir * _movespeed * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(_newdir);


    }
}
