using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
          if (collider.CompareTag("Player"))
          {   
              Destroy(gameObject);
          }
      }
}
