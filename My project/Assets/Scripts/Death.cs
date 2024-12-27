using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] private LayerMask triggerLayerMask;

    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(triggerLayerMask, other.gameObject.layer))
        {
            SceneManager.LoadScene(0);
        }
    }
}
