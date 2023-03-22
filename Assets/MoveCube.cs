using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Rigidbody rigitBody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigitBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Vector3.right * Time.deltaTime;
        }



        if (Input.GetKey(KeyCode.A))
        {
           transform.position = transform.position + Vector3.left * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigitBody.AddForce(Vector3.up*20, ForceMode.Impulse);
        }

    }
}
