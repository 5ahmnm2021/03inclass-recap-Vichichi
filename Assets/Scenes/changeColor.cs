using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeColor : MonoBehaviour
{
    private int Randomizer;

    public Image colorImage;

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Randomizer = Random.Range(0, 4);

            Debug.Log(Randomizer);

            if(Randomizer == 0)
            {   
                colorImage.color = new Color32(255,205,25,100);
            }
            
            if(Randomizer == 1)
            {
                colorImage.color = new Color32(95,34,0,100);
            }

            if(Randomizer == 2)
            {
                colorImage.color = new Color32(207,63,21,100);
            }

            if(Randomizer == 3)
            {
                colorImage.color = new Color32(102,47,84,100);
            }
        }
    }
}
  