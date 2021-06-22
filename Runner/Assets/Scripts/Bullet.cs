using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right);
        if(hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("ship"))
            {
                hitInfo.collider.GetComponent<ship>().TakeDamage();
                Destroy(gameObject);
            }
            if (transform.position.x >= 11) {
                Destroy(gameObject); 
            }
            
        }
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
