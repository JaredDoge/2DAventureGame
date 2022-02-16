using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed= 5;
    private Rigidbody2D _rigidbody2D;

    private Animator _animator;

    private float x;
    private float y;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D=GetComponent<Rigidbody2D>();
        _animator=GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        x=Input.GetAxis("Horizontal");
        y=Input.GetAxis("Vertical");

        if(x>0)
        {
            transform.eulerAngles=new Vector3(0,0,0);
            _animator.SetBool("run",true);
        }

        if(x<0) 
        {
             transform.eulerAngles=new Vector3(0,180f,0f);
            _animator.SetBool("run",true);
        }
        

        if(x<0.001f && x>-0.001f)
        {
            _animator.SetBool("run",false);
        }

        Run();
    
    }

    private void Run()
    {
        Vector3 movement=new Vector3(x,y,0);
        transform.position += movement * speed * Time.deltaTime;

    }
}
