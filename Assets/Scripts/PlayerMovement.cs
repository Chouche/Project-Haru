using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Implements `TouchToMove` function
/// </summary>
public class PlayerMovement : MonoBehaviour
{
#if UNITY_EDITOR
    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;
    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis
#endif

    void Start ()
    {
		
	}
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray,
                maxDistance: 100, layerMask: Layers.Floor,
                hitInfo: out hit))
            {
                StopAllCoroutines();
                StartCoroutine(MoveFunc(hit.point));
            }
        }

#if UNITY_EDITOR
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");
        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;
        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);
        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;
#endif
    }
    IEnumerator MoveFunc(Vector3 target)
    {
        target = new Vector3(target.x, transform.position.y, target.z);

        for (int i = 0; i < 40; i++)
        {
            transform.position += (target - transform.position) * 0.15f;
            yield return null;
        }
        transform.position = target;
    }
}
