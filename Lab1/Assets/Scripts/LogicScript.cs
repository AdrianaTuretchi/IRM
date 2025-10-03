using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public Transform firstCharacter;
    public Transform secondCharacter;
    public float attackDistance = 0.25f; 

    public Animator firstAnimator;
    public Animator secondAnimator;

    void Update()
    {
        float distance = Vector3.Distance(firstCharacter.position, secondCharacter.position);

        if (distance <= attackDistance)
        {
            firstAnimator.SetTrigger("TrAttack");
            secondAnimator.SetTrigger("TrAttack");
        }
        else
        {
            firstAnimator.SetTrigger("TrIdle");
            secondAnimator.SetTrigger("TrIdle");
        }
    }
}
