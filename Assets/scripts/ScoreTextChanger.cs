using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �A�C�e�����j�󂳂ꂽ�ꍇ�ɃX�R�A�\���ɕύX��������
public class ScoreTextChanger : MonoBehaviour
{
    // �N���A�ɕK�v�ȃX�R�A
    [SerializeField]
    int regulationScore;

    // �ύX��������e�L�X�g
    [SerializeField]
    TMPro.TextMeshProUGUI scoreText;

    // �c��̃X�R�A��\������B�G��|�������ɌĂ΂��
    public void ChangeScore(int score)
    {
        // �c��̃A�C�e������ύX����
        scoreText.SetText("Enemy {0} / {1}", score, regulationScore);
    }

    void Start()
    {
        // �ŏ��Ȃ̂�0�Őݒ�
        scoreText.SetText("Enemy 0 / {0}", regulationScore);
    }
}