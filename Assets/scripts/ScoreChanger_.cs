using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChanger_ : MonoBehaviour
{
    // UI表示の機能を使用するために取得
    [SerializeField]
    TMPro.TextMeshProUGUI textMeshPro;

    // アイテムの残り個数を数える
    [System.NonSerialized]
    public int numberOfItem;

    // アイテムが破壊(取得)されたときに呼ばれる
    public void RemoveScore()
    {
        // 残りの個数を減らす
        --numberOfItem;
        // 残りの個数でテキストを表示
        textMeshPro.SetText("Enemy{0}", numberOfItem);
    }

    // Start is called before the first frame update
    void Start()
    {
        // 最初なのでアイテムの最大数で初期化する
        numberOfItem = 50;
        // 数を設定したので反映
        textMeshPro.SetText("Enemy{0}", numberOfItem);
    }
}