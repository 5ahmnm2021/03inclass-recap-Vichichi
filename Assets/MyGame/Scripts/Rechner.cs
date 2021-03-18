using UnityEngine;
using UnityEngine.UI;

public class Rechner : MonoBehaviour
{
    public InputField input1;
    public InputField input2;

    public Text ergebnisTxt;

    private bool num1 = true;
    private bool num2 = true;

    public void AddNumbers()
    {
        int ersteNummer = 0;
        int zweiteNummer = 0;

        int ergebnis = 0;

        string fehlerTxt = "Geben Sie eine gültige Zahl ein";

        try
        {
            ersteNummer = int.Parse(input1.text);
            input1.image.color = Color.white;
            num1 = true;
        }

        catch (System.Exception)
        {
            input1.image.color = Color.red;
            input1.text = fehlerTxt;
            num1 = false;
        }

        try
        {
            zweiteNummer = int.Parse(input2.text);
            input2.image.color = Color.white;
            num2 = true;
        }

        catch (System.Exception)
        {
            input2.image.color = Color.red;
            input2.text = fehlerTxt;
            num2 = false;
        }

        if(num1 && num2)
        {
            ergebnis = ersteNummer + zweiteNummer;

            ergebnisTxt.text = ergebnis.ToString();
        }
    }
}
