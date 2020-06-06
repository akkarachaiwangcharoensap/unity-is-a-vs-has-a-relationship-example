using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class BagComponent : MonoBehaviour
{
    /**
     * <summary>
     * Storage to keep items inside the bag.
     * </summary>
     */
    protected List<GameObject> _storage;

    public List<GameObject> storage
    {
        set
        {
            this._storage = value;
        }

        get
        {
            return this._storage;
        }
    }

    // Use this for initialization
    protected virtual void Start()
    {
        this.storage = new List<GameObject>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {

    }
}
