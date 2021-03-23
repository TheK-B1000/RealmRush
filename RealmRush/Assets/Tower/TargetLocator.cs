using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] Transform target;

   void Start()
    {
        // Set the enemy
        target = FindObjectOfType<EnemyMover>().transform;
    }

    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        // Weapon look at target;
        weapon.LookAt(target.transform.position);
    }
}
