using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKodu : MonoBehaviour
{
    
    public Vector3 topDirection;
    public float hiz;
    // Start is called before the first frame update
    void Start()
    {
        topDirection = Vector3.forward;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (topDirection.x == 0)
            {
                topDirection = Vector3.left;
            }
            else
            {
                topDirection = Vector3.forward;
            }
       
        }
       
    }

    private void FixedUpdate()
    {
        Vector3 hareket = topDirection * Time.deltaTime * hiz;
        transform.position += hareket;
    }
     
    
}
