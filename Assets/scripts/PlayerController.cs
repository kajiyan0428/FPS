using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �v���C���[�̈ړ�����
public class PlayerController : MonoBehaviour
{
    // �ړ����x
    [SerializeField]
    float moveSpeed;

    // �J�����̏��B��]�̓��@�Ɏg�p
    [SerializeField]
    Transform cameraTransform;

    void Move()
    {
        // W�L�[�������ꂽ��
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
        // S�L�[�������ꂽ��
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -moveSpeed * Time.deltaTime);

        }
        // D�L�[�������ꂽ��
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        // A�L�[�������ꂽ��
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
    }

    // �J�����̌����Ɠ��@����
    void RotateSynchro()
    {
        transform.rotation = cameraTransform.rotation;
    }

    void Update()
    {
        // �ړ�����
        Move();
        // ��]�����B�J�����Ɠ���
        RotateSynchro();
    }
}