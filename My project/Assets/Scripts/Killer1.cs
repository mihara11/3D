using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killer1 : MonoBehaviour
{
    [SerializeField] private LayerMask playerMask;

    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(playerMask, other.gameObject.layer))
        {
            SceneManager.LoadScene(0);
        }
    }
}
