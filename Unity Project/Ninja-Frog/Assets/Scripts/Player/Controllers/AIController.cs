using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "AIController", menuName = "InputController/AIController")]

public class AIController : InputController
{
    public override float RetrieveMoveInput()
    {
        return 1f;
    }

    public override bool RetrivejumpInput()
    {
        return true;
    }
}
