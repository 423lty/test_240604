using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //playerの速さ
    const int PLAYER_SPEED = 5;

    // Start is called before the first frame update
    void Start()
    {
        //フレームレートを60に固定
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //ゲームオーバーを管理

        //ひだりキーを押したら左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(-PLAYER_SPEED * Time.deltaTime, 0, 0);
        }
        //右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(PLAYER_SPEED * Time.deltaTime, 0, 0);
        }
        //ゲームおーば―かどうか
        if (GameObject.Find("GameDirector1").GetComponent<GameDirector1>().IsGameOver())
        {
            Destroy(gameObject);

        }

    }
    public void LButtonDown()
    {
        transform.Translate(-PLAYER_SPEED * Time.deltaTime, 0, 0);
    }
    public void RButtonDown() {
        transform.Translate(PLAYER_SPEED * Time.deltaTime, 0, 0);
    }
}
