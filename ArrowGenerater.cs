using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerater : MonoBehaviour
{
    //prefabに使うオブジェクトを生成
    public GameObject ArrowPrefab;
    //float span = 1.0f;
    float span = 0.1f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("GameDirector1").GetComponent<GameDirector1>().IsGameOver())
        {
            Destroy(this);
            return;
        }
        //deltatimeに時間経過を追加
        this.delta += Time.deltaTime;
        //一秒を経過したらやを生成する
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(ArrowPrefab);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
