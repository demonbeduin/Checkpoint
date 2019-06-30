using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCameraRay : MonoBehaviour
{
    public Camera _camera;
    public GameObject _prefab;
    public GameObject _player;
    public float _speed = 20f;
    public float _rSpeed = 1f;
    Vector3 _dir;

    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool collision = Physics.Raycast(ray.origin, ray.direction, out hit);

        if (collision)
        {
            if (Input.GetMouseButtonDown(0))
            {
                print(hit.point);

                _dir = (hit.point - _player.transform.position);
                //_player.transform.position = Vector3.MoveTowards(_player.transform.position, hit.point, _movespeed * Time.deltaTime);

                //Instantiate(_prefab, hit.point, Quaternion.identity);
            }
            if (Vector3.Distance(hit.point, _player.transform.position) > 1)
            {
                Vector3 _newdir = Vector3.RotateTowards(_player.transform.forward, _dir, _rSpeed * Time.deltaTime, 0.0F);
                _player.transform.rotation = Quaternion.LookRotation(_newdir);
                _player.transform.position += _dir * _speed * Time.deltaTime;
            }
        }
    }
}
