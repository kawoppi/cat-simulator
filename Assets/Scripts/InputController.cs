using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private CatController catController;

    void Awake()
    {
        catController = GetComponent<CatController>();
    }

    void FixedUpdate()
    {
        int vertical = Mathf.RoundToInt(Input.GetAxisRaw("Vertical"));
        int horizontal = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
        bool jump = Input.GetKey(KeyCode.Space);
        catController.ForwardInput = vertical;
        catController.TurnInput = horizontal;
        catController.JumpInput = jump;
    }
}
