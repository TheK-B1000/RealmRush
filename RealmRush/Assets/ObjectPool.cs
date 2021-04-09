using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnTimer = 1f;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(SpawnEnemy(spawnTimer));
    }

    private IEnumerator SpawnEnemy(float timer)
    {
        while (true)
        {
            Instantiate(enemyPrefab, transform);
            yield return new WaitForSeconds(timer);
        }

    }
}
