using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public float plusSpeed;
    public float MaxSpeed;
    public float downWall;
    public GameObject effectObj;
    private Animator camAnim;
    private int std01;

    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }
    public void TakeDamage()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed);
        if (transform.position.x <= downWall) { 
            Destroy(gameObject); 
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
          if (collider.CompareTag("Player"))
        {
            camAnim.SetTrigger("collision");
            Instantiate(effectObj, transform.position, Quaternion.identity);
            collider.GetComponent<Player>().heatls -= damage;
            Destroy(gameObject);
            speed += plusSpeed;
          }
          if (collider.CompareTag("Ammo"))
        {
            Destroy(gameObject);
        }
    }
}
