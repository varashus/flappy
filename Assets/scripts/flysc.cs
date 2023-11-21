using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class flysc : MonoBehaviour
{

    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _roataionspeed = 10f;
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        
        if (/*Mouse.current.leftButton.wasPressedThisFrame*/Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = Vector2.up * _velocity;
            

        } 
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rigidbody2D.velocity.y * _roataionspeed);
        
    }
}
