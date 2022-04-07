using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRSceneController : MonoBehaviour
{
    public Transform xrOrigin;
    public virtual void Init() {}

    public virtual Transform GetXRRig() {
        return xrOrigin;
    }
}
