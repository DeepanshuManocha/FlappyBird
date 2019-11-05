using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPipe : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject);

       if ((collision.gameObject.CompareTag("Pipe")))
        {
            Destroy(collision.gameObject);
            Debug.Log("Collision");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
