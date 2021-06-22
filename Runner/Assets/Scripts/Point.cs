using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject Obj;
    public void Start()
    {
        Instantiate(Obj, transform.position, Quaternion.identity);
    }
}
