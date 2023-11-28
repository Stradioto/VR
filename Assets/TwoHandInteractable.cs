using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandInteractable : XRGrabInteractable
{
    public List<XRSimpleInteractable> secondHandGrabPoints = new List<XRSimpleInteractable>();
    private XRBaseInteractor secondInteractor;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var item in secondHandGrabPoints)
        {
            item.onSelectEntered.AddListener(OnSecondHandGrab);
            item.onSelectExited.AddListener(OnSecondHandRelease);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        if (secondInteractor && selectingInteractor)
        {
            selectingInteractor.attachTransform.rotation = Quaternion.LookRotation(secondInteractor.attachTransform.position
                                                                                    - selectingInteractor.attachTransform.position);
        }
        base.ProcessInteractable(updatePhase);
    }

    public void OnSecondHandGrab(XRBaseInteractor interactor)
    {
        secondInteractor = interactor;
    }

    public void OnSecondHandRelease(XRBaseInteractor interactor)
    {
        secondInteractor = null;
    }

    //protected override void OnSelectEnter(XRBaseInteractor interactor)
    //{

    //}

    //protected override void OnSelectExit(XRBaseInteractor interactor)
    //{

    //}

    public override bool IsSelectableBy(XRBaseInteractor interactor)
    {
        bool isalreadygrabbed = selectingInteractor && !interactor.Equals(selectingInteractor);
        return base.IsSelectableBy(interactor);
    }
}
