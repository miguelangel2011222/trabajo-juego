using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movimiento : MonoBehaviour
{   
    public float speed=1.0f;
    public float jumpforce=1.0f;

    private Rigidbody fisicas;
    
    // Start is called before the first frame update
    void Start()
    {
        fisicas=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      float horizontal=Input.GetAxis("Horizontal");
      float vertical=Input.GetAxis("Vertical");

      transform.Translate(new Vector3(horizontal,0.0f,vertical)*Time.deltaTime*speed);

      if(Input.GetKeyDown(KeyCode.Space))
      {
      fisicas.AddForce(new Vector3(0,jumpforce,0),ForceMode.Impulse);
      }
      
    }
}
