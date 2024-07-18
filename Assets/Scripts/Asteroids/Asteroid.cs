using UnityEngine;

public class Asteroid : SpaceObject
{
    public Sprite[] sprites;
    protected SpriteRenderer sr;

    public float size = 1;
    public float minSize = 0.4f;
    public float maxSize = 2f;
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

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.layer == 6){
            if ((size * .5f) >= minSize)
            {
                CreateSplitAsteroid();
                CreateSplitAsteroid();
            }

            Destroy(gameObject);
            VFXManager.Instance.TriggerExplosion(transform);
        }
    }

    void CreateSplitAsteroid()
    {
        Vector2 currentPosition = transform.position;
        currentPosition += Random.insideUnitCircle * .5f;

        new AsteroidBuilder(AsteroidSpawner.Instance.asteroidPrefab)
            .InstantiateAsteroid(currentPosition, transform.rotation)
            .SetSize(size * 0.5f) 
            .SetTrajectory(Random.insideUnitCircle.normalized * speed) 
            .Build();
    }
}
