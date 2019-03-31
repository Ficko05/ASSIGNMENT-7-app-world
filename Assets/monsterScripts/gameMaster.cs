using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {

    public float coins ;
    public Text goldText;
    public Text upgradeText;
    public float goldMultiplyser = 1;
    float priceOfUpgrade = 20; 

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
        
        if(coins >= priceOfUpgrade)
        {
            coins = coins - priceOfUpgrade;
            setCountText();
            goldMultiplyser = goldMultiplyser * 2;
            priceOfUpgrade = priceOfUpgrade * 4;
            setCountText();
        }
        
    }

    void setCountText()
    {
        goldText.text = "Gold x " + coins.ToString();
        upgradeText.text = "Gold-Boost X2 \n" + "Price " + priceOfUpgrade.ToString() + " Gold";
    }
}


