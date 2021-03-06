using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPool : MonoBehaviour
{
    public static bulletPool BulletPoolIntanse;

    [SerializeField] 
    private GameObject pooledbullet;

    private bool notEnoughBulletInPool = true;

    private List<GameObject> bullets;

    private void Awake()
    {
        BulletPoolIntanse = this;
        
    }
    

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
        
    }

    // Update is called once per frame
    public GameObject getBullet()
    {
        if (bullets.Count > 0)
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                if (!bullets[i].activeInHierarchy)
                {
                    return bullets[i];
                }
            }
        }

        if (notEnoughBulletInPool)
        {
            GameObject bul = Instantiate(pooledbullet);
            bul.SetActive(false);
            bullets.Add(bul);
            return bul;
        }

        return null;
    }
}
