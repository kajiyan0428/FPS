using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ’e‚ğŠÇ—
public class Bullet : MonoBehaviour
{
    // ’e‚Ì‘¬“x
    [SerializeField]
    float bulletSpeed;
    // ‹@”\‚ğg‚¤
    Rigidbody rigidbody;
    // õ–½
    [SerializeField]
    float lifeSpan;
    // Œo‰ßŠÔ‚ğŒv‘ª
    float currentTime;
    // ‚P‰ñ‚Ì—Í‚Å¨‚¢—Ç‚­”ò‚Î‚·
    void Fry()
    {
        rigidbody.AddForce(transform.forward * bulletSpeed, ForceMode.VelocityChange);
    }
    // ‰½‚©‚É“–‚½‚Á‚½‚ç
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        // Åy‘c‚È‚Ì‚ÅŒo‰ß‚Í‚O
        currentTime = 0;

        rigidbody = GetComponent<Rigidbody>();

        // ’e‚ğ”ò‚Î‚·
        Fry();
    }
    void Update()
    {
        // Œo‰ßŠÔ‚ğ‰ÁZ
        currentTime += Time.deltaTime;
        // ¶‘¶ŠÔ‚ªõ–½‚ğ’´‚¦‚½‚ç
        if (currentTime > lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}