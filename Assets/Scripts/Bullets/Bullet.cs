using UnityEngine;

public class Bullet : SpaceObject
{
    [SerializeField] private float maxLifeTime = 5f;

    protected override void Start()
    {
        base.Start();
        rb.drag = 0;
    }

    public void ThrowProjectile(Vector2 direction)
    {
        rb.velocity = Vector2.zero; // Önceki hareketi sıfırla
        rb.AddForce(direction * speed);
        Invoke(nameof(ReturnToPool), maxLifeTime);
    }

    private void ReturnToPool()
    {
        BulletPoolManager.Instance.ReturnBullet(this);
    }
}