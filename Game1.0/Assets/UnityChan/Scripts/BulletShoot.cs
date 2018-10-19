﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    private GameObject bulletPredab;
    public Transform prantTransform;
    public float speedBullet = 3f;

    private void Start()
    {
        bulletPredab = Resources.Load<GameObject>("Effect");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateBullet();
        }
    }

    public void CreateBullet()
    {
        Debug.Log("生成了一个子弹");
        GameObject go = Instantiate(bulletPredab, prantTransform.position, prantTransform.rotation);
        go.GetComponent<Rigidbody>().velocity = prantTransform.forward * speedBullet;
    }
}