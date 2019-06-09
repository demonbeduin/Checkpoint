using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject _prefab;

    void Start()
    {
        InvokeRepeating("Res", 0, 5f);
    }
    private void Res()
    {
        GameObject obj = Instantiate(_prefab, transform.position, Quaternion.identity);
        Destroy(obj, 10f);
    }

    void Update()
    {
                
    }
}
