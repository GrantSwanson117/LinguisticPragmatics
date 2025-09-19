using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticActorScript : MonoBehaviour
{
    public AnimationClip currentAnim;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

        if (currentAnim != null)
        {
            anim.Play(currentAnim.name);
        }
    }
}
