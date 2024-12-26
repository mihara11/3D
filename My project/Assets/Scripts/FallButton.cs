using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallButton : MonoBehaviour
{
    [SerializeField] private LayerMask triggerLayerMask;

    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(triggerLayerMask, other.gameObject.layer))
        {
            other.isTrigger = true;
        }
    }

}
