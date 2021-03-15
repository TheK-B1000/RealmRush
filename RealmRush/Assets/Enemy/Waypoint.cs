using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool IsPlaceable;
    private void OnMouseOver()
    {
        if (IsPlaceable && Input.GetMouseButtonDown(0))
        {
            Debug.Log(transform.name);
        }
    }
}
