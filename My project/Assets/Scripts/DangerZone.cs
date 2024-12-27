using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    [SerializeField] private bool isOneShot;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private GameObject killerPrefab;
    [SerializeField] private Transform KillerSpawnPoint;
    private int _ShotCount;
    private int _maxhotcount = 1;
    
    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskUtil.ContainsLayer(playerMask, other.gameObject.layer))
        {
            if (isOneShot && _ShotCount < _maxhotcount || !isOneShot)
            {
                Instantiate(killerPrefab, KillerSpawnPoint);
                _ShotCount++;
            }

           
        }
    }
}
