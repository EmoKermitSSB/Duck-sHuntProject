using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gun : MonoBehaviour
{
    [SerializeField] public AudioManager audioManager;

    public Transform bulletSpawnPoint;

    public GameObject bulletPrefab;

    public float bulletSpeed = 10;

    public float countdown = 1;

    public float initialValue = 1;

    private Animator GunAnim;


    private void Awake()
    {

    }

    private void Start()
    {
        GunAnim = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioManager.PlaySFX(audioManager.shoot);
            GunAnim.SetBool("Shoot", true);
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
    
    void ResetFire()
    {
        GunAnim.SetBool("Shoot", false);
    }
       
    
}