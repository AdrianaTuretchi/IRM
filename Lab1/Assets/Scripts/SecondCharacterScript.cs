using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SecondCharacterScript : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {
            if (Keyboard.current.enterKey.wasPressedThisFrame || Keyboard.current.numpadEnterKey.wasPressedThisFrame)
            { Debug.Log("Enter Pressed");
                animator.ResetTrigger("TrAttack");
                animator.SetTrigger("TrAttack");
            }
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                animator.SetTrigger("TrIdle");
            }
        }
    }
}