using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jumpVelocity= 5f;

   // public float jumpAmount = 10;

    private Rigidbody2D _rigidbody2D;
    private bool jumpRequest= false;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
           // _rigidbody2D.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
           jumpRequest=true;
        }
        
    }

    private void FixedUpdate() 
    {
        if(jumpRequest)
        {
            _rigidbody2D.AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
            jumpRequest=false;
        }
    }



}
