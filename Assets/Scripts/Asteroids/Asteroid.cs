using UnityEngine;

public class Asteroid : SpaceObject
{
    public Sprite[] sprites;
    protected SpriteRenderer sr;

    public float size = 1;
    public float minSize = 0.5f;
    public float maxSize = 1.5f;
    public float maxLifetime = 30.0f;

    protected override void Awake()
    {
        base.Awake();
        sr = GetComponent<SpriteRenderer>();
    }

    protected override void Start()
    {
        base.Start();
        rb.gravityScale = 0;
        rb.angularDrag = 0;
        rb.drag = 0;

        sr.sprite = sprites[Random.Range(0, sprites.Length)];
        transform.eulerAngles = new Vector3(0, 0, Random.value * 360f);
        transform.localScale = Vector3.one * size;

        rb.mass = size;
    }

    public void SetTrajectory(Vector2 direction)
    {
        rb.AddForce(direction * speed);
        Destroy(gameObject, maxLifetime);
    }
}
