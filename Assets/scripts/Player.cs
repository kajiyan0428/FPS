using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// �v���C���[�{�̂��Ǘ�
public class Player : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // �G�ɓ���������I���
        if (collision.gameObject.name == "Enemy(Clone)")
        {
            // �V�[�������[�h
            SceneManager.LoadScene("GameOverScene");
        }
    }
}