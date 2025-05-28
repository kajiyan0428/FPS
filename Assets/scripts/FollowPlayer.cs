using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �J�����ɃA�^�b�`���ăv���C���[�ɒǏ]������
public class FollowPlayer : MonoBehaviour
{
    // �v���C���[�̃g�����X�t�H�[����m��
    [SerializeField]
    Transform playerTransform;
    // �Ǐ]���邽�߂Ƀv���C���[�̍��W��m��
    Vector3 playerPosition;

    // �J�����𗣂����߂Ƀv���C���[�Ƃ̋�����m���Ă���
    Vector3 offset;

    void Start()
    {
        // �J�����̋�����ݒ肷�邽�߂Ƀv���C���[�̈ʒu��m��
        playerPosition = playerTransform.position;
        // �������g��target�Ƃ̋������v�Z����
        offset = gameObject.transform.position - playerPosition;
    }

    void FixedUpdate()
    {
        // �v���C���[�̈ʒu����ɋ����Ă��炤
        playerPosition = playerTransform.position;
        // �v���C���[�̈ʒu����offset�̕����ꂽ�ʒu�Ɉړ�����
        gameObject.transform.position = playerPosition + offset;
    }
}