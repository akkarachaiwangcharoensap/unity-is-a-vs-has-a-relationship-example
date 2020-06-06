using UnityEngine;
using System.Collections;

public class BoyComponent : HumanComponent
{

    // Use this for initialization
    protected override void Start()
    {
        base.Start();

        this.WhatBagDoIHave();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    /**
     * <summary>
     * What kind of bag does the boy have?
     * </summary>
     *
     */
    protected override void WhatBagDoIHave ()
    {
        if (this._bagComponent == null)
        {
            Debug.Log("I don't have a bag.");

            return;
        }

        if (this._bagComponent is MessengerBagComponent)
        {
            Debug.Log("I have a messenger bag! Horay!");
        }

        else if (this._bagComponent is PurseBagComponent)
        {
            Debug.Log("I have a purse bag! Horay...");
        }
    }
}
