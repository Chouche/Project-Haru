using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffWhenClicked : Interactible
{
    public string @switch;

    public override void OnMouseDown()
    {
        Switch.TurnOff(@switch);
    }
}
