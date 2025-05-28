using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// スコアをカウントしてゲームクリアかチェックする
public class GameClearChecker : MonoBehaviour
{
    // 得点
    [System.NonSerialized]
    public int score;

    // クリアに必要なスコア
    [SerializeField]
    int regulationScore;

    [SerializeField]
    ScoreTextChanger scoreTextChanger;

    // 得点を加算
    public void AddScore()
    {
        // １点追加
        ++score;

        // UIにも変更をかける
        scoreTextChanger.ChangeScore(score);
    }

    void Update()
    {
        // 得点と既定の点数が同じなら
        if (score == regulationScore)
        {
            // ゲームクリア
            SceneManager.LoadScene("GameClearScene");
        }
    }
}