using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChanger : MonoBehaviour
{

    private float levelThreshold = 1.0f;
    public float currentAlpha;
    private MeshRenderer renderer;
    public String sceneName;
    private Color currentColor;
    
    void Start()
    {
        this.enabled = true;
        renderer = gameObject.GetComponent<MeshRenderer>();
        currentColor = renderer.material.color;
    }

    void Update()
    {
        //UnityEngine.Debug.Log(currentColor.a);
        currentColor.a = currentAlpha;
        renderer.material.color = currentColor;
        if (currentColor.a == levelThreshold)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
