using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneswitch : MonoBehaviour
{
    public void Color()
    {
        Application.LoadLevel(1);
    }

    public void Rechner()
    {
        Application.LoadLevel(2);
    }

    public void StartScene()
    {
        Application.LoadLevel(0);
    }
}
