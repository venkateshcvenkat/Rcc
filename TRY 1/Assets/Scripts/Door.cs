using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;
    public bool isOpenned = false;
    

    public void DoorAnimation()
    {
        isOpenned = !isOpenned;
        if (isOpenned)
        {
            animator.Play("Open");
        }
        else
        {
            animator.Play("Close");
        }
    }
}
