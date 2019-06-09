using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private GameObject _playerTarget;
    public float _movespeed;

    void Start()
    {
        _playerTarget = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        Vector3 _dir = (_playerTarget.transform.position - transform.position).normalized;
        Quaternion _enemyRotation = Quaternion.LookRotation(_dir);
        transform.position += _dir * _movespeed * Time.deltaTime;
        transform.rotation = _enemyRotation;

        //Vector3 _newdir = Vector3.RotateTowards(_playerTarget.transform.forward, _dir, _movespeed * Time.deltaTime, 0.0F);
        //_playerTarget.transform.rotation = Quaternion.LookRotation(_dir);

    }
}
