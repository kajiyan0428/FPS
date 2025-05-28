using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �J�����̌�����ς���
public class CameraRotater : MonoBehaviour
{
    // ���t���[���}�E�X�̃|�W�V�������o���Ă���
    Vector3 lastMousePosition;

    // �v�Z�������ʂ�����p
    Vector3 newAngle = new Vector3(0, 0, 0);

    // ��]�̌��E�l�B�㉺�̌����̐����Ɏg�p
    [SerializeField]
    float rotateLimit;

    // ��]�̑��x
    [SerializeField]
    float rotateSpeed;

    // �J�[�\���̈ړ����E�n�_�B��ʒ�����0
    [SerializeField]
    float cursorMoveLimit;

    void Start()
    {
        // �J�����̌������擾
        newAngle = transform.localEulerAngles;

        // �}�E�X�J�[�\���̃|�W�V�������擾
        lastMousePosition = Input.mousePosition;

        // �}�E�X�J�[�\�����\���ɂ���
        Cursor.visible = false;
    }

    // �J��������]������
    void CameraRotation()
    {
        // �J�[�\���Ƀ��b�N���������Ă��Ȃ���
        if (Cursor.lockState == CursorLockMode.None)
        {
            // �J�[�\�����ړ����������ɑ��x��������
            newAngle.y += (Input.mousePosition.x - lastMousePosition.x) * rotateSpeed * Time.deltaTime;
            newAngle.x -= (Input.mousePosition.y - lastMousePosition.y) * rotateSpeed * Time.deltaTime;

            // �J���������E�����X���Ă�������E�n����
            newAngle.x = Mathf.Min(newAngle.x, rotateLimit);
            newAngle.x = Mathf.Max(newAngle.x, -rotateLimit);

            // �v�Z�����p�x��ݒ�
            gameObject.transform.localEulerAngles = newAngle;
        }

        // �}�E�X�|�C���^�[�������������̒l�ȏ㗣�ꂽ�ꍇ
        if (Mathf.Abs(Screen.width * 0.5f - Input.mousePosition.x) > cursorMoveLimit ||
            Mathf.Abs(Screen.height * 0.5f - Input.mousePosition.y) > cursorMoveLimit)

        {
            // ��ʒ����ɃJ�[�\����߂��ă��b�N
            Cursor.lockState = CursorLockMode.Locked;
            lastMousePosition = Input.mousePosition;
        }
        else
        {
            // �J�[�\���̃��b�N������
            Cursor.lockState = CursorLockMode.None;
            lastMousePosition = Input.mousePosition;
        }
    }

    void FixedUpdate()
    {
        CameraRotation();
    }
}