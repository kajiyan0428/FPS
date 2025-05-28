using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �e���Ǘ�
public class Bullet : MonoBehaviour
{
    // �e�̑��x
    [SerializeField]
    float bulletSpeed;
    // �@�\���g��
    Rigidbody rigidbody;
    // ����
    [SerializeField]
    float lifeSpan;
    // �o�ߎ��Ԃ��v��
    float currentTime;
    // �P��̗͂Ő����ǂ���΂�
    void Fry()
    {
        rigidbody.AddForce(transform.forward * bulletSpeed, ForceMode.VelocityChange);
    }
    // �����ɓ���������
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        // ��y�c�Ȃ̂Ōo�߂͂O
        currentTime = 0;

        rigidbody = GetComponent<Rigidbody>();

        // �e���΂�
        Fry();
    }
    void Update()
    {
        // �o�ߎ��Ԃ����Z
        currentTime += Time.deltaTime;
        // �������Ԃ������𒴂�����
        if (currentTime > lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}