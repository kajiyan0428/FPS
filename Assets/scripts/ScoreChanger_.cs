using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChanger_ : MonoBehaviour
{
    // UI�\���̋@�\���g�p���邽�߂Ɏ擾
    [SerializeField]
    TMPro.TextMeshProUGUI textMeshPro;

    // �A�C�e���̎c����𐔂���
    [System.NonSerialized]
    public int numberOfItem;

    // �A�C�e�����j��(�擾)���ꂽ�Ƃ��ɌĂ΂��
    public void RemoveScore()
    {
        // �c��̌������炷
        --numberOfItem;
        // �c��̌��Ńe�L�X�g��\��
        textMeshPro.SetText("Enemy{0}", numberOfItem);
    }

    // Start is called before the first frame update
    void Start()
    {
        // �ŏ��Ȃ̂ŃA�C�e���̍ő吔�ŏ���������
        numberOfItem = 50;
        // ����ݒ肵���̂Ŕ��f
        textMeshPro.SetText("Enemy{0}", numberOfItem);
    }
}