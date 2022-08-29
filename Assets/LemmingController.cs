using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemmingController : MonoBehaviour
{
    public float moveDirection = 1f;
    public CharacterMovementController controller;

    private void Update()
    {





        controller.Move(moveDirection);

    }
}
