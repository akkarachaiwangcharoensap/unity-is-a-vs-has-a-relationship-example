using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HumanComponent : MonoBehaviour
{
    /**
     * <summary>
     * Bag game object
     * </summary>
     */
    public GameObject bag;

    /**
     * <summary>
     * Bag component
     * </summary>
     */
    protected BagComponent _bagComponent;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        this._bagComponent = this.bag.GetComponent<BagComponent>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    // The subclasses will need to implement the function...
    protected abstract void WhatBagDoIHave();
}
