using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private GameObject cube1;


    void Update()
    {
        cube1.transform.Rotate(0f, 0.0f, 90.0f * speed, Space.Self);
    }
}
