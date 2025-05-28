using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// カメラにアタッチしてプレイヤーに追従させる
public class FollowPlayer : MonoBehaviour
{
    // プレイヤーのトランスフォームを知る
    [SerializeField]
    Transform playerTransform;
    // 追従するためにプレイヤーの座標を知る
    Vector3 playerPosition;

    // カメラを離すためにプレイヤーとの距離を知っておく
    Vector3 offset;

    void Start()
    {
        // カメラの距離を設定するためにプレイヤーの位置を知る
        playerPosition = playerTransform.position;
        // 自分自身とtargetとの距離を計算する
        offset = gameObject.transform.position - playerPosition;
    }

    void FixedUpdate()
    {
        // プレイヤーの位置を常に教えてもらう
        playerPosition = playerTransform.position;
        // プレイヤーの位置からoffsetの分離れた位置に移動する
        gameObject.transform.position = playerPosition + offset;
    }
}