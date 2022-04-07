using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Area1Controller : XRSceneController
{

    public XRSocketInteractor keyCardSocket;
    public XRBaseInteractable keyCard;
    public Transform xrRigOrigin2;

    public override void Init() {
        if (PlayerManager.Instance.hasVisitedArea2) {
            keyCardSocket.startingSelectedInteractable = keyCard;
        }
    }

    public override Transform GetXRRig()
    {
        return PlayerManager.Instance.hasVisitedArea2 ? xrRigOrigin2 : xrOrigin;
    }
}
