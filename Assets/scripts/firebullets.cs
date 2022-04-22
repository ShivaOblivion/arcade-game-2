using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebullets : MonoBehaviour
{
    [SerializeField] private int bulletsAmout = 10;

    [SerializeField] private float starAngle = 90f, endAngel = 270f;

    private Vector2 bulletMoveDiretion;
    
    
    void Start()
    {
        InvokeRepeating("Fire",0f,2f);
    }

    private void Fire()
    {
        float angleSetp = (endAngel - starAngle) / bulletsAmout;
        float angle = starAngle;
        
        for (int i = 0; i < bulletsAmout; i++)
        {
            float bolDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bolDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);
            Vector3 bulMoveVector = new Vector3(bolDirX, bolDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = bulletPool.BulletPoolIntanse.getBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<bulletShip>().SetMovDirection(bulDir);
            angle += angleSetp;


        }
        Debug.Log("fire!!!");
    }
        
}
