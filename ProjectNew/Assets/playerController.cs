using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class playerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed;
    public GameObject origin;
    public int range = 3;
    private float xPos;
    private float yPos;
    public GameObject root;
    private bool disabled = false;
    private int count;

    private Vector2 ogpos;

 
    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody2D>();


    }
    // Update is called once per frame




    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (disabled == false)
        {
            ogpos = transform.position;
            if (mousePos.x < origin.transform.position.x + 3 && mousePos.x > origin.transform.position.x - 3)
            {
                xPos = mousePos.x;
            }
            if (mousePos.y < origin.transform.position.y + 3 && mousePos.y > origin.transform.position.y - 3)
            {
                yPos = mousePos.y;
            }

            transform.position = new Vector2(xPos, yPos);
        }

        if (Input.GetMouseButtonDown(0) && disabled == false)
        {
            disabled = true;
            Instantiate(root, transform.position, Quaternion.identity);
            
        }

        if (Input.GetMouseButtonDown(0))
        {
            count++;
        }
        if (Input.GetMouseButtonDown(1))
        {

            if (count == 1)
            {
                disabled = false;
            }
            if (count != 0)
            {
                count--;
            }
            
        }




        /* if (transform.position.x < mousePos.x + 0.1 && transform.position.x > mousePos.x - 0.1)
         {
             rb.velocity = Vector2.zero;
         }
         else
         {
             if (mousePos.x < transform.position.x)
             {
                 rb.velocity = new Vector2(0, 0);
                 rb.AddForce(Vector2.left * speed);

             }
             else if (mousePos.x > transform.position.x)
             {
                 rb.velocity = new Vector2(0, 0);
                 rb.AddForce(Vector2.right * speed);
             }
         }

         if (transform.position.y < mousePos.y + 0.1 && transform.position.y > mousePos.y - 0.1)
         {
             rb.velocity = Vector2.zero;



         }
         else
         {
             if (mousePos.y > transform.position.y)
             {
                 rb.velocity = new Vector2(0, 0);
                 rb.AddForce(Vector2.up * speed);
             }
             else if (mousePos.y < transform.position.y)
             {
                 rb.velocity = new Vector2(0, 0);
                 rb.AddForce(Vector2.down * speed);

             }
         }
        */
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("wall");
            
        }

    }

}
