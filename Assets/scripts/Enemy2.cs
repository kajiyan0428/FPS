using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// �G�l�~�[�̖{�̂��Ǘ�
public class Enemy2 : MonoBehaviour
{
    // ���ꂽ�Ƃ��ɃX�R�A�Ǘ��҂ɒʒm
    GameClearChecker gameClearChecker;

    // �ڕW�̃I�u�W�F�N�g
    GameObject destinationObj;

    // �ڕW�̍��W
    Vector3 destinationPos;

    // �G�[�W�F���g�̋@�\
    NavMeshAgent agent;

    // �����蔻��
    void OnCollisionEnter(Collision collision)
    {
        // �e�ɓ����������������S
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Destroy(gameObject);

            // ���_��ǉ�
            gameClearChecker.AddScore();
        }
    }

    void Start()
    {
        // �N���A���`�F�b�N����X�N���v�g��T��
        gameClearChecker = GameObject.Find("GameClearChecker").GetComponent<GameClearChecker>();

        destinationObj = GameObject.Find("Player");

        agent = GetComponent<NavMeshAgent>();

        // �ڕW�n�_�̍��W
        destinationPos = destinationObj.transform.position;

        // �ړI�n�ɐݒ�
        agent.destination = destinationPos;
    }

    void Update()
    {
        // �Ώۂ������̂ŏ�ɍX�V
        destinationPos = destinationObj.transform.position;
        agent.destination = destinationPos;
    }
}