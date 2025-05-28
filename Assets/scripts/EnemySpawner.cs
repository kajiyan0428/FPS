using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �G�𐶐�����
public class EnemySpawner : MonoBehaviour
{
    // ����������G�I�u�W�F�N�g
    [SerializeField]
    GameObject enemyObj;

    // �G�����܂��Ԋu(�b)
    [SerializeField]
    int spawnInterval;

    // �o�ߎ��Ԃ��v��
    float currentTime;

    // �X�e�[�W�̒[(�ǂ̕��𔲂����傫��)
    [SerializeField]
    float stageSize;

    // �����ʒu�B���܂�new�������Ȃ��̂ŗ\�ߍ���Ďg����
    Vector3 spawnPos;

    void Start()
    {
        // ������
        spawnPos = new();

        // �ŏ��Ȃ̂Ōo�߂͂O
        currentTime = 0;
    }

    // �����_���ȍ��W��Ԃ��B���������Ȃ��̂łx�͂O
    Vector3 RandomPositionXZ()
    {
        spawnPos.x = Random.Range(-stageSize, stageSize);
        // �����`�Ȃ̂�Z������
        spawnPos.z = Random.Range(-stageSize, stageSize);

        return spawnPos;
    }

    void Update()
    {
        // �o�ߎ��Ԃ����Z
        currentTime += Time.deltaTime;

        // �C���^�[�o�����o�߂�����
        if (currentTime > spawnInterval)
        {
            Instantiate(enemyObj, RandomPositionXZ(), Quaternion.identity);

            // �^�C�}�[���Z�b�g
            currentTime = 0;
        }
    }
}