using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool IsPlaceable;
    private void OnMouseOver()
    {
        if (IsPlaceable && Input.GetMouseButtonDown(0))
        {
            if (towerPrefab.transform.position != transform.position)
            {
                Instantiate(towerPrefab, transform.position, Quaternion.identity);
                IsPlaceable = false;
            }
        }
    }
}
