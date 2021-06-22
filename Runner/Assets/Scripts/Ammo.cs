using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public int plusAmmo = 1;
    public float speed;
    public float downWall;
    private void Update()
    {
        transform.Translate(Vector2.left * speed);
        if (transform.position.x <= downWall)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            collider.GetComponent<Gun>().Charge += plusAmmo;
            Destroy(gameObject);
        }
    }
}
