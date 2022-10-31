using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ThirdPersonCharacterController : MonoBehaviour
{
    #region private
    [SerializeField] float
        attackTime = 0.125f,
        releaseTime = 0.125f;
    [SerializeField] Rigidbody rb;
    Vector2 movement = Vector2.zero;
    bool shouldMove = false;
    #endregion



    public Camera camera;


    public void StartMoving(Vector2 movement)
    {
        this.movement = movement;
        shouldMove = true;
    }
    public void StopMoving()
    {
        shouldMove = false;
    }

    private void FixedUpdate()
    {
        if (shouldMove)
        {
            AnimationCurve test = AnimationCurve.EaseInOut(0f, 0f, attackTime, 1f);

            test.Evaluate()

        }
    }
}
