using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCintroller : MonoBehaviour
{
    //�I�u�W�F�N�g�Ƃ���player��ǉ�
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        //�q�G�����L�[�ɐݒ肵�Ă���I�u�W�F�N�g����
        this.Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //�t���[�����ɓ����ŗ�������
        transform.Translate(0, -0.1f, 0);

        //��ʊO�ɏo����I�u�W�F�N�g���͂�����
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //�����蔻���ǉ�
        Vector2 p1 = transform.position;                      //��̒��S���W
        Vector2 p2 = this.Player.transform.position;          //player�̃I�u�W�F�N�g���S���Ws
        Vector2 dir = p1 - p2;                                 //���player�Ƃ̋���s 
        float d = dir.magnitude;                            //
        float r1 = 0.5f;                                    //��̔��a
        float r2 = 1.0f;                                    //player�̔��a

        //player�ɂ���������
        if (d < r1 + r2)
        {
            //�f�B���N�g���X�N���v�g��player���̏Փ˂������Ă�����
            GameObject director = GameObject.Find("GameDirector1");
            //GameDirector�̃Q�[�W�����炷
            director.GetComponent<GameDirector1>().DecreaseHp();
            Destroy(gameObject);
        }


    }
}
