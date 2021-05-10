using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public int damage = 40;
    public GameObject bulletPrefab;
    public LineRenderer lineRender;
    public GameObject impactEffect;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

        if (hitInfo)
        {
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            //     lineRender.SetPosition(0,firePoint.position);
            //     lineRender.SetPosition(1, hitInfo.point);
            // }else
            // {
            //     lineRender.SetPosition(0,firePoint.position);
            //     lineRender.SetPosition(1, firePoint.position + firePoint.right * 100);

        }
        // lineRender.enabled = true;
        // //wait one frame
        // yield return new WaitForSeconds(0.02f);
        // lineRender.enabled = false;
    } 
}