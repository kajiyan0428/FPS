using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// エネミーの本体を管理
public class Enemy : MonoBehaviour
{
    // 目標のオブジェクト
    GameObject destinationObj;

    // 目標の座標
    Vector3 destinationPos;

    // エージェントの機能
    NavMeshAgent agent;

    // 当たり判定
    void OnCollisionEnter(Collision collision)
    {
        // 弾に当たった時だけ死亡
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        destinationObj = GameObject.Find("Player");

        agent = GetComponent<NavMeshAgent>();

        // 目標地点の座標
        destinationPos = destinationObj.transform.position;

        // 目的地に設定
        agent.destination = destinationPos;
    }

    void Update()
    {
        // 対象が動くので常に更新
        destinationPos = destinationObj.transform.position;
        agent.destination = destinationPos;
    }
}