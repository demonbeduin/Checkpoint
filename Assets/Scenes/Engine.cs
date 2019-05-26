using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public Transform player;
    public Transform target;
    public float speed;

    void Start()
    {
        player.rotation = Quaternion.identity;
        target.rotation = Quaternion.identity;
    }

    void Update()
    {
        Vector3 targetDir = (player.position - target.position).normalized;
        Vector3 newDir = Vector3.RotateTowards(target.transform.forward, targetDir, speed * Time.deltaTime, 0.0F);
        target.transform.rotation = Quaternion.LookRotation(newDir);

        //Vector3 relativePos = player.transform.position - target.transform.position;
        //Quaternion _rotation = Quaternion.LookRotation(relativePos);
        //target.transform.rotation = _rotation;
        //target.transform.LookAt(player);
    }
}
