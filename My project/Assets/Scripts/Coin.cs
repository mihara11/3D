using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int Price;
    [SerializeField] private LayerMask playerLayerMask;

    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(playerLayerMask, other.gameObject.layer))
        {
            if (other.TryGetComponent(out Score playerScore))
            {
                playerScore.AddScore(Price);
                gameObject.SetActive(false);
            }
        }
    }

}
