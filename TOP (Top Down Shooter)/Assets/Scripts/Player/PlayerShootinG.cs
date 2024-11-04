using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootin : MonoBehaviour
{
    [SerializeField] float playerBulletSpeed = 10f;
    [SerializeField] GameObject playerBullet;
    [SerializeField] GameObject playerGun;
    void Start()
    {
        
    }
    
    void OnFire()
    {
        GameObject bullet = Instantiate(playerBullet, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * playerBulletSpeed, ForceMode2D.Impulse);
    }

    void Update()
    {
        
    }
}
