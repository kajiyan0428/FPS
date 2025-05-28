using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// �X�R�A���J�E���g���ăQ�[���N���A���`�F�b�N����
public class GameClearChecker : MonoBehaviour
{
    // ���_
    [System.NonSerialized]
    public int score;

    // �N���A�ɕK�v�ȃX�R�A
    [SerializeField]
    int regulationScore;

    [SerializeField]
    ScoreTextChanger scoreTextChanger;

    // ���_�����Z
    public void AddScore()
    {
        // �P�_�ǉ�
        ++score;

        // UI�ɂ��ύX��������
        scoreTextChanger.ChangeScore(score);
    }

    void Update()
    {
        // ���_�Ɗ���̓_���������Ȃ�
        if (score == regulationScore)
        {
            // �Q�[���N���A
            SceneManager.LoadScene("GameClearScene");
        }
    }
}