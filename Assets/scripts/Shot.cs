using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // �e�̃I�u�W�F�N�g
    [SerializeField]
    GameObject bulletPrefab;
    // �e���̃I�u�W�F�N�g�B���W�̎擾�Ɏg�p
    [SerializeField]
    GameObject muzzleObj;
    // �e���̍��W
    Vector3 muzzulePosition;
    // �e���̌���
    Quaternion muzzuleRotation;
    // ���[�g�B���b�Ԋu�Ō��Ă邩
    [SerializeField]
    float FireLate;
    // �o�ߎ��Ԃ��v��
    float currentTime;
    void Start()
    {
        // �ŏ��Ȃ̂Ōo�߂͂O
        currentTime = 0;
        // ���W
        muzzulePosition = muzzleObj.transform.position;
        // ����
        muzzuleRotation = muzzleObj.transform.rotation;
    }
    // �}�Y���������̂ŏ����X�V
    void UpdateMuzzuleTransdorm()
    {
        // ���W
        muzzulePosition = muzzleObj.transform.position;
        // ����
        muzzuleRotation = muzzleObj.transform.rotation;
    }
    void StraightShot()
    {
        Instantiate(bulletPrefab, muzzulePosition, muzzuleRotation);
    }
    // �ݒ肵�����[�g�̒ʂ�ɓ������悤�Ƀ`�F�b�N����
    bool CheckFireLate()
    {
        if (currentTime > FireLate)
        {
            // �������̂Ń^�C�}�[���Z�b�g
            currentTime = 0;
            return true;
        }
        else return false;
    }
    void Update()
    {
        // �}�Y���̏��͏�ɍX�V
        UpdateMuzzuleTransdorm();
        // ���Ԍo�߂����Z
        currentTime += Time.deltaTime;
        // �L�[���͌��m
        if (Input.GetKey(KeyCode.Space))
        {
            // �t�@�C�A���[�g�𒴂��Ȃ����`�F�b�N
            if (CheckFireLate())
            {
                // �e�𐶐�
                StraightShot();
            }
        }
    }
}