using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTarget : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        print("OnCollisionEnter" + collision.gameObject.name);
        Object _obj = gameObject;
        if (collision.gameObject.name == "Sphere(Clone)")
        {
            Destroy(_obj);
        }
    }

    private void OnCollisionExit(UnityEngine.Collision collision)
    {
        print("OnCollisionExit" + collision.gameObject.name);
    }

    void Update()
    {
        
    }
}
