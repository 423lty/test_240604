using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCintroller : MonoBehaviour
{
    //オブジェクトとしてplayerを追加
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        //ヒエラルキーに設定しているオブジェクトを代入
        this.Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //フレーム事に等速で落下する
        transform.Translate(0, -0.1f, 0);

        //画面外に出たらオブジェクトをはきする
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //当たり判定を追加
        Vector2 p1 = transform.position;                      //やの中心座標
        Vector2 p2 = this.Player.transform.position;          //playerのオブジェクト中心座標s
        Vector2 dir = p1 - p2;                                 //矢とplayerとの距離s 
        float d = dir.magnitude;                            //
        float r1 = 0.5f;                                    //矢の半径
        float r2 = 1.0f;                                    //playerの半径

        //playerにあったたら
        if (d < r1 + r2)
        {
            //ディレクトリスクリプトにplayerｔの衝突を教えてあげる
            GameObject director = GameObject.Find("GameDirector1");
            //GameDirectorのゲージを減らす
            director.GetComponent<GameDirector1>().DecreaseHp();
            Destroy(gameObject);
        }


    }
}
