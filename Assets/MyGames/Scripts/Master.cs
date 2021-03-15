using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour
{
    public Text text;
    public Light light;
    public Camera camera;

    public int MyFontSize;
    public float MyCookieSize;
    public float MyDepth;

    void Update()
    {
        text.fontSize = MyFontSize;
        light.cookieSize = MyCookieSize;
        camera.depth = MyDepth;
    }
}
