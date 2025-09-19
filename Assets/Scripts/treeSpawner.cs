using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeSpawner : MonoBehaviour
{
    [SerializeField]
    private float spawnTime = 1f;
    public GameObject treePrefab;
    void Start()
    {
        InvokeRepeating("SpawnTree", 0f, spawnTime);
    }
    void SpawnTree()
    {
        if (treePrefab != null)
        {
            Instantiate(treePrefab, transform.position, transform.rotation);
        }
    }
}
