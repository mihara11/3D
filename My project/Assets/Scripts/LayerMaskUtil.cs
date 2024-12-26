using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LayerMaskUtil
{
    public static bool ContainsLayer(LayerMask layermask, int layer)
    {
        return (layermask.value & 1 << layer) > 0;
    }
}
