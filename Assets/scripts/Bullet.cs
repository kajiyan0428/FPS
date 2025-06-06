using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 弾を管理
public class Bullet : MonoBehaviour
{
    // 弾の速度
    [SerializeField]
    float bulletSpeed;
    // 機能を使う
    Rigidbody rigidbody;
    // 寿命
    [SerializeField]
    float lifeSpan;
    // 経過時間を計測
    float currentTime;
    // １回の力で勢い良く飛ばす
    void Fry()
    {
        rigidbody.AddForce(transform.forward * bulletSpeed, ForceMode.VelocityChange);
    }
    // 何かに当たったら
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        // 最y祖なので経過は０
        currentTime = 0;

        rigidbody = GetComponent<Rigidbody>();

        // 弾を飛ばす
        Fry();
    }
    void Update()
    {
        // 経過時間を加算
        currentTime += Time.deltaTime;
        // 生存時間が寿命を超えたら
        if (currentTime > lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}