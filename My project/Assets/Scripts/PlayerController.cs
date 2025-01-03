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
    [SerializeField] private LayerMask coinMask;
    [SerializeField] private Score playerScore;

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
        Vector3 direction = transform.forward * movespeed * value;
        Vector3 combinedDirection = new Vector3(direction.x, _rb.velocity.y, direction.z);

        _rb.velocity = combinedDirection;
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

    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(coinMask, other.gameObject.layer))
        {
            if (other.TryGetComponent(out Coin coin))
            {
                
                other.gameObject.SetActive(false);
            }
        }
    }
}
