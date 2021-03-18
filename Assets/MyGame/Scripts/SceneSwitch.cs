using UnityEngine;

public class SceneSwitch : MonoBehaviour
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
