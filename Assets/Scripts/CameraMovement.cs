using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject camera;
    void Start()
    {
        //target = pl
    }

    void LateUpdate()
    {
        transform.rotation = Quaternion.identity;
    }
}