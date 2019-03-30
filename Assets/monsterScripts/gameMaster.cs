using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {

    public float coins ;
    public Text countText;
    public float goldMultiplyser = 1;

    public void onclickMonster()
    {

        goldBank(goldMultiplyser);
        setCountText();
    }


    public void goldBank(float x)
    {
        coins = coins + x;
        
    }

    public void goldUpgrade()
    {
        if(coins >= 10)
        {
            print("buy");
            coins = coins - 10;
            setCountText();
            goldMultiplyser = goldMultiplyser * 2;
        }
        print("pressed");

    }

    void setCountText()
    {
        countText.text = "Gold x " + coins.ToString();
    }
}
