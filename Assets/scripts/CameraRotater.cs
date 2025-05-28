using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// カメラの向きを変える
public class CameraRotater : MonoBehaviour
{
    // 毎フレームマウスのポジションを覚えておく
    Vector3 lastMousePosition;

    // 計算した結果を入れる用
    Vector3 newAngle = new Vector3(0, 0, 0);

    // 回転の限界値。上下の向きの制限に使用
    [SerializeField]
    float rotateLimit;

    // 回転の速度
    [SerializeField]
    float rotateSpeed;

    // カーソルの移動限界地点。画面中央が0
    [SerializeField]
    float cursorMoveLimit;

    void Start()
    {
        // カメラの向きを取得
        newAngle = transform.localEulerAngles;

        // マウスカーソルのポジションを取得
        lastMousePosition = Input.mousePosition;

        // マウスカーソルを非表示にする
        Cursor.visible = false;
    }

    // カメラを回転させる
    void CameraRotation()
    {
        // カーソルにロックがかかっていない時
        if (Cursor.lockState == CursorLockMode.None)
        {
            // カーソルが移動した距離に速度をかける
            newAngle.y += (Input.mousePosition.x - lastMousePosition.x) * rotateSpeed * Time.deltaTime;
            newAngle.x -= (Input.mousePosition.y - lastMousePosition.y) * rotateSpeed * Time.deltaTime;

            // カメラが限界よりも傾いていたら限界地を代入
            newAngle.x = Mathf.Min(newAngle.x, rotateLimit);
            newAngle.x = Mathf.Max(newAngle.x, -rotateLimit);

            // 計算した角度を設定
            gameObject.transform.localEulerAngles = newAngle;
        }

        // マウスポインターが中央から既定の値以上離れた場合
        if (Mathf.Abs(Screen.width * 0.5f - Input.mousePosition.x) > cursorMoveLimit ||
            Mathf.Abs(Screen.height * 0.5f - Input.mousePosition.y) > cursorMoveLimit)

        {
            // 画面中央にカーソルを戻してロック
            Cursor.lockState = CursorLockMode.Locked;
            lastMousePosition = Input.mousePosition;
        }
        else
        {
            // カーソルのロックを解く
            Cursor.lockState = CursorLockMode.None;
            lastMousePosition = Input.mousePosition;
        }
    }

    void FixedUpdate()
    {
        CameraRotation();
    }
}