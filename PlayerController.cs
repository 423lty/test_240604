using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player�̑���
    const int PLAYER_SPEED = 5;

    // Start is called before the first frame update
    void Start()
    {
        //�t���[�����[�g��60�ɌŒ�
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //�Q�[���I�[�o�[���Ǘ�

        //�Ђ���L�[���������獶�Ɉړ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(-PLAYER_SPEED * Time.deltaTime, 0, 0);
        }
        //�E�Ɉړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(PLAYER_SPEED * Time.deltaTime, 0, 0);
        }
        //�Q�[�����[�΁\���ǂ���
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
