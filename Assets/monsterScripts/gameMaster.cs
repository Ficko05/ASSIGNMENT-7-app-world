using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class gameMaster : MonoBehaviour {

    public float coins;
    public Text goldText;
    public Text upgradeText;
    public float goldMultiplyser = 1;
    float priceOfUpgrade = 20;
    public GameObject gameOverUI1M;
    public GameObject gameOverUI50M;
    float clickCounterForAds;

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
            clickCounterForAds++;
            if(clickCounterForAds%3 == 0){ 
            
                Advertisement.Show();
            }
        } 
    }


    public void winGameButton1M()
    {
        
        if(coins >= 1000000f)
        {
            gameOverUI1M.SetActive(true);
        }
    }


    public void winGameButton50M()
    {
        if (coins >= 9999999f)
        {
            gameOverUI50M.SetActive(true);
        }
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("MenuScene");

    }

    void setCountText()
    {
        goldText.text = "Gold x " + coins.ToString();
        upgradeText.text = "Boost x2 " + priceOfUpgrade.ToString() + "G";
    }
}


