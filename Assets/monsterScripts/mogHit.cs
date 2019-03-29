using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mogHit : MonoBehaviour {

    public int coins;
    public Text countText;

    public void onclick()
    {
        print("Sprite Clicked");

        coins++;
        setCountText();
    }

   

    public void setCountText()
    {
        countText.text = "Gold x " + coins.ToString();
    }
}
