using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class personScript : MonoBehaviour
{
    private Rigidbody rb;
    private Animator anim;
    private Animator bubbleAnim;
    public bool isWalking;
    public bool isSitting;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        if(isSitting){anim.SetTrigger("sitting");}
        if (anim == null){UnityEngine.Debug.Log("Animator not found.");}
        if (isWalking)
        {anim.SetBool("isWalking", true);}
    }

    void Update()
    {
        if (isWalking)
        {anim.SetBool("isWalking", true);}
        else {anim.SetBool("isWalking", false);}
    }
}
