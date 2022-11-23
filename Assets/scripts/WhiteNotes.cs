using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WhiteNotes : MonoBehaviour
{
    //tone= Sounds that plays in app
    //delegate= get and prepare for doing somethig else
    public static event Action<string> toneName = delegate{};

    //Unity is crossplatform - left click in mouse is the same as touch in mobile phones
    //So you can use this method to both phone and pc
    private void OnMouseDown () {
        //set name of sounds
        toneName(name);
    }
}
