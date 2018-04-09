using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactible : MonoBehaviour
{
	void Start ()
    {
		
	}

    /// <summary>
    /// Will be executed when user clicked the object
    /// (UnityEvent)
    /// </summary>
    public virtual void OnMouseDown()
    {
    }

    /// <summary>
    /// (CustomEvent, See PlayerInteraction.cs)
    /// </summary>
    public virtual void OnBeginHover()
    {
    }
    /// <summary>
    /// (CustomEvent, See PlayerInteraction.cs)
    /// </summary>
    public virtual void OnEndHover()
    {
    }
}
