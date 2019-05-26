using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public Transform player;
    public Transform target;
    public int speed;

    void Start()
    {
        player.rotation = Quaternion.identity;
        target.rotation = Quaternion.identity;
    }

    void Update()
    {
        //Vector3 relativePos = (target.transform.position - player.transform.position).normalized;
        //Quaternion rotation = Quaternion.LookRotation(relativePos);
        //target.transform.rotation = rotation;
        target.transform.LookAt(player);
    }
}
