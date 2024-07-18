using System.Collections.Generic;
using UnityEngine;

public class BulletPoolManager : BaseManager<BulletPoolManager>
{
    public Bullet bulletPrefab;
    private Queue<Bullet> bullets = new Queue<Bullet>();
    [SerializeField] private int poolSize = 15;

    protected override void Awake()
    {
        base.Awake();
        InitializePool();
    }

    private void InitializePool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            Bullet bullet = Instantiate(bulletPrefab, transform);
            bullet.gameObject.SetActive(false);
            bullets.Enqueue(bullet);
        }
    }

    public Bullet GetBullet()
    {
        if (bullets.Count > 0)
        {
            Bullet bullet = bullets.Dequeue();
            bullet.gameObject.SetActive(true);
            return bullet;
        }
        else
        {
            Debug.Log("All bullets are in use!");
            return null;
        }

        // eğer mevcut bulletları resetlemek isterseniz;
        /*
            foreach (Bullet bullet in bullets)
            {
                if (!bullet.gameObject.activeInHierarchy)
                {
                    bullet.gameObject.SetActive(true);
                    return bullet;
                }
            }

            // Tüm bulletlar kullanımdaysa, ilk bullet'ı resetle ve kullan
            Bullet oldestBullet = bullets[0];
            oldestBullet.ResetBullet();
            oldestBullet.gameObject.SetActive(true);
            return oldestBullet;
        */
    }

    public void ReturnBullet(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
        bullets.Enqueue(bullet);
    }
}