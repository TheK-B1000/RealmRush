using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    [SerializeField] int currentHitPoints = 0;
    [SerializeField] GameObject enemy;

    // Start is called before the first frame update
    void OnEnable()
    {
        // Set the enemy
        enemy = GetComponent<GameObject>();

        // Set current hit points
        currentHitPoints = maxHitPoints;
    }

    void ProcessHit()
    {
        currentHitPoints--;
        if (currentHitPoints == 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnParticleCollision(GameObject enemy)
    {
        if (currentHitPoints != 0)
        {
            ProcessHit();
        }
    }
}
