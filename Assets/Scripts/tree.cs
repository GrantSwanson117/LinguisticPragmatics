using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class tree : MonoBehaviour
{
    public float treeLifetime = 10f;
    [SerializeField]
    public float moveSpeed = 75f;

    void Start()
    {
        StartCoroutine(DestroyTree());
    }
    IEnumerator DestroyTree()
    {
        yield return new WaitForSeconds(treeLifetime);
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
