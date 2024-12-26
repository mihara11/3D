using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private bool turnON;
    [SerializeField] private GameObject switchableObject;

    [SerializeField] private LayerMask triggerLayerMask;

    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(triggerLayerMask, other.gameObject.layer))
        {
            switchableObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(triggerLayerMask, other.gameObject.layer))
        {
            switchableObject.SetActive(false);
        }
    }
}
