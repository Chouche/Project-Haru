using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnWhenClicked : Interactible
{
    public string @switch;

    public override void OnMouseDown()
    {
        Switch.TurnOn(@switch);
    }
}

