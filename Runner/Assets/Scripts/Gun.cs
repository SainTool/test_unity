using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Position;

    public int Charge;

    private float timeShot;
    public float startTimeShot;
    private void Update()
    {
        if (Charge > 3)
        { Charge = 3; }
        if (timeShot <= 0 && Charge == 3)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(Bullet, transform);
                timeShot = startTimeShot;
                Charge = 0;
            }
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
    }
}
