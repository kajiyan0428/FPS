using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// アイテムが破壊された場合にスコア表示に変更をかける
public class ScoreTextChanger : MonoBehaviour
{
    // クリアに必要なスコア
    [SerializeField]
    int regulationScore;

    // 変更をかけるテキスト
    [SerializeField]
    TMPro.TextMeshProUGUI scoreText;

    // 残りのスコアを表示する。敵を倒した時に呼ばれる
    public void ChangeScore(int score)
    {
        // 残りのアイテム数を変更する
        scoreText.SetText("Enemy {0} / {1}", score, regulationScore);
    }

    void Start()
    {
        // 最初なので0で設定
        scoreText.SetText("Enemy 0 / {0}", regulationScore);
    }
}