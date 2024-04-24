using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlManage : MonoBehaviour
{
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count++;
        }
        if (Input.GetMouseButtonDown(1))
        {
            
            if (count == 0)
            {
                Destroy(gameObject);
            }
            count--;
        }
    }
}
