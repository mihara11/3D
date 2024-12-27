using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killer : MonoBehaviour
{
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private LayerMask groundMask;
    private bool _isGrounded = false;

    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(groundMask, other.gameObject.layer))
        {
            _isGrounded = true;
        }

        if (LayerMaskUtil.ContainsLayer(playerMask, other.gameObject.layer))
        {
            if (!_isGrounded)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
