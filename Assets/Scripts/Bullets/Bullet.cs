using UnityEngine;

public class Bullet : SpaceObject {

    [SerializeField] private float maxLifeTime;
    protected override void Start()
    {
        base.Start();
        rb.drag = 0;
    }

    public void ThrowProjectile(Vector2 direction){
        rb.AddForce(direction * speed);
        Destroy(gameObject, maxLifeTime);
    }
}