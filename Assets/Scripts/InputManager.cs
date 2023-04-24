using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Camera sceneCamera;

    private Vector3 lastPosition;

    [SerializeField]
    private LayerMask layerMask;

    public Vector3 GetSelectedMapPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = sceneCamera.nearClipPlane;
        //Debug.Log(mousePosition);

        Ray ray = sceneCamera.ScreenPointToRay(mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray,out hit, 100, layerMask))
        {
            lastPosition = hit.point;
            //Debug.Log(hit.distance);
        }
        return lastPosition;
    }
}
