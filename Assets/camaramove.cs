using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto : MonoBehaviour
{   public float rotationspeed=1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float rotationY=Input.GetAxis("Mouse X");
      transform.Rotate(new Vector3(0,rotationY*Time.deltaTime*rotationspeed,0));  
    }
}
