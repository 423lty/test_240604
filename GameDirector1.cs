using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
public class GameDirector1 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject hpGage;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGage = GameObject.Find("hpGage");
        this.gameOver = GameObject.Find("GameOver");
        gameOver.SetActive(false);
    }

    private void Update()
    {
        if(IsGameOver())
        {
            this.gameOver.SetActive(true);
        }
    }
    // Update is called once per frame
    public void DecreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public bool IsGameOver()
    {
        if (this.hpGage.GetComponent<Image>().fillAmount <= 0.0f)
        {
            //this.hpGage.GetComponent<Image>().fillAmount = 1.0f;
            return true;
        }
        return false;
    }
}
