using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float up;
    public float down;
    public int heatls;
    public GameObject effectpl;
    public Text healthDisplay;
    public GameObject panel;
    private Animator camAnim;

    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }
    private void Update()
    {
        healthDisplay.text = heatls.ToString();
        if (heatls <= 0)
        {
            panel.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < up)
        {
            camAnim.SetTrigger("shake");
            Instantiate(effectpl, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x , transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > down)
        {
            camAnim.SetTrigger("shake");
            Instantiate(effectpl, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
    public void UpBottonOn()
    {
        if (transform.position.y < up)
        {
            camAnim.SetTrigger("shake");
            Instantiate(effectpl, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
    }
    public void DownBottonOn()
    {
        if (transform.position.y > down)
        {
            camAnim.SetTrigger("shake");
            Instantiate(effectpl, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}
