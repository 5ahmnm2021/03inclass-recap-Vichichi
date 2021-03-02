using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rechner : MonoBehaviour
{
    public InputField Input1;
    public InputField Input2;

    public float ersteNummer;
    public float zweiteNummer; 

    public float Ergebnis;

    public Text ErgebnisTxt;

    void Update()
    {
        ersteNummer = float.Parse(Input1.text);
        zweiteNummer = float.Parse(Input2.text);
    }

    public void AddNumbers()
    {
        Ergebnis = ersteNummer + zweiteNummer;

        ErgebnisTxt.text = Ergebnis.ToString();
    }
}
