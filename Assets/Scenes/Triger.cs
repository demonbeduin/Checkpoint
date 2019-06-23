using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{
    private GameObject _targetTriger;

    void Start()
    {

        _targetTriger = GameObject.FindWithTag("Light_5");
        _targetTriger.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            print("OnTriggerEnter" + other.name);
            _targetTriger.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            print("OnTriggerExit" + other.name);
            _targetTriger.SetActive(false);
        }
    }

    void Update()
    {
        
    }
}
