using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 敵を生成する
public class EnemySpawner : MonoBehaviour
{
    // 生成させる敵オブジェクト
    [SerializeField]
    GameObject enemyObj;

    // 敵が生まれる間隔(秒)
    [SerializeField]
    int spawnInterval;

    // 経過時間を計測
    float currentTime;

    // ステージの端(壁の分を抜いた大きさ)
    [SerializeField]
    float stageSize;

    // 生成位置。あまりnewしたくないので予め作って使い回す
    Vector3 spawnPos;

    void Start()
    {
        // 初期化
        spawnPos = new();

        // 最初なので経過は０
        currentTime = 0;
    }

    // ランダムな座標を返す。浮きたくないのでＹは０
    Vector3 RandomPositionXZ()
    {
        spawnPos.x = Random.Range(-stageSize, stageSize);
        // 正方形なのでZも同じ
        spawnPos.z = Random.Range(-stageSize, stageSize);

        return spawnPos;
    }

    void Update()
    {
        // 経過時間を加算
        currentTime += Time.deltaTime;

        // インターバルを経過したか
        if (currentTime > spawnInterval)
        {
            Instantiate(enemyObj, RandomPositionXZ(), Quaternion.identity);

            // タイマーリセット
            currentTime = 0;
        }
    }
}