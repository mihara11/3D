using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] private float rotationspeed;
    [SerializeField] private float jumpforce;
    [SerializeField] private KeyCode jumpkey;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveForward = Input.GetAxis("Vertical");
        float rotate = Input.GetAxis("Horizontal");

        Move(moveForward);
        Rotate(rotate);

        if (Input.GetKeyDown(jumpkey))
        {
            Jump();
        }
    }

    private void Move(float value)
    {
        //Vector3 moveDir = new Vector3(0, _rb.velocity.y, value * movespeed);
        //_rb.velocity = moveDir;

        _rb.velocity = transform.forward * movespeed * value;
    }

    private void Jump()
    {
        //TODO add force to rigidbody
        _rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
    }

    private void Rotate(float value)
    {
        //TODO rotate rigidbody  or transform with value
        transform.Rotate(Vector3.up,value * rotationspeed * Time.deltaTime);
    }
}
