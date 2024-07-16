using System;
using UnityEngine;

public class Player : SpaceObject
{
    public Bullet bulletPrefab;
    public static event Action<bool> OnThrustChanged;
    public static event Action<float> OnTurnChanged;

    public float turning { get; set; }
    public bool thrusting { get; set; }

    [SerializeField] public float turnSpeed = 1.0f;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void FixedUpdate() 
    {
        base.FixedUpdate();
        HandleEvents();
    }

    private void HandleEvents()
    {
        if (thrusting)
            rb.AddForce(this.transform.up * speed);
        if (turning != 0)
            rb.AddTorque(turning * turnSpeed);
    }

    public void Shoot(){
        Bullet bullet = BulletPoolManager.Instance.GetBullet();
        if (bullet != null)
        {
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            bullet.ThrowProjectile(transform.up);
        }
    }

    public void ChangeThrust(bool thrust) => OnThrustChanged?.Invoke(thrust);
    public void ChangeTurn(float turn) => OnTurnChanged?.Invoke(turn);
}
