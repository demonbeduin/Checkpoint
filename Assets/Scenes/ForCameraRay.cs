using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCameraRay : MonoBehaviour
{
    public Camera _camera;
    public GameObject _prefab;

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
                //Instantiate(_prefab, hit.point, Quaternion.identity);
            }
        }
    }
}
