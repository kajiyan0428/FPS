using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// プレイヤーの移動処理
public class PlayerController : MonoBehaviour
{
    // 移動速度
    [SerializeField]
    float moveSpeed;

    // カメラの情報。回転の同機に使用
    [SerializeField]
    Transform cameraTransform;

    void Move()
    {
        // Wキーが押されたか
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
        // Sキーが押されたか
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -moveSpeed * Time.deltaTime);

        }
        // Dキーが押されたか
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        // Aキーが押されたか
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
    }

    // カメラの向きと同機する
    void RotateSynchro()
    {
        transform.rotation = cameraTransform.rotation;
    }

    void Update()
    {
        // 移動処理
        Move();
        // 回転処理。カメラと同期
        RotateSynchro();
    }
}