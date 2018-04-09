using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Implements look-based interaction
/// </summary>
public class PlayerInteraction : MonoBehaviour
{
    private GameObject hoveredObject;

	void Start () {
		
	}

    void LateUpdate()
    {
        ProcessRaycast();
    }

    private void ProcessRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(
            Camera.main.transform.position, Camera.main.transform.forward,
            out hit))
        {
            SetHoveredObject(hit.collider.gameObject);
        }
        else
            SetHoveredObject(null);
    }

    private void SetHoveredObject (GameObject g)
    {
        if (hoveredObject != g)
        {
            if (hoveredObject != null)
                hoveredObject.SendMessage("OnEndHover");

            if (g != null)
                g.SendMessage("OnBeginHover");
        }

        hoveredObject = g;
    }
}
