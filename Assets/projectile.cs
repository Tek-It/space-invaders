using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static triangles;

public class projectile : MonoBehaviour
    
{
    public Transform firePoint;
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    void Start()
    {
        
    }
    void Shoot()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.right);
        if (hit) // If this is true then it hits something
        {
            Debug.Log("Hit " + hit.collider.gameObject);

            Enemy enemy = hit.collider.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.GetDamage();

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
}
