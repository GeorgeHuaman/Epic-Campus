using SpatialSys.UnitySDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public string url;

    public void OpenUrl()
    {
        SpatialBridge.spaceService.OpenURL(url);
    }
}
