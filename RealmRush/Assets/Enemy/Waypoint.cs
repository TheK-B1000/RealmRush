using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;

    [SerializeField] bool isPlaceable;
    public bool IsPlaceable {get { return isPlaceable; } }

    private void OnMouseOver()
    {
        if (isPlaceable && Input.GetMouseButtonDown(0))
        {
            if (towerPrefab.transform.position != transform.position)
            {
                Instantiate(towerPrefab, transform.position, Quaternion.identity);
                isPlaceable = false;
            }
        }
    }
}
