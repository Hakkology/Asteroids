using UnityEngine;

public class AsteroidBuilder
{
    private Asteroid asteroidInstance;
    private Asteroid asteroidPrefab;

    public AsteroidBuilder(Asteroid asteroidPrefab)
    {
        this.asteroidPrefab = asteroidPrefab;
    }

    public AsteroidBuilder InstantiateAsteroid(Vector3 position, Quaternion rotation)
    {
        asteroidInstance = MonoBehaviour.Instantiate(asteroidPrefab, position, rotation);
        asteroidInstance.gameObject.SetActive(true);
        return this;
    }

    public AsteroidBuilder SetSize(float size)
    {
        asteroidInstance.size = size;
        asteroidInstance.transform.localScale = Vector3.one * size;
        return this;
    }

    public AsteroidBuilder SetTrajectory(Vector2 direction)
    {
        asteroidInstance.SetTrajectory(direction);
        return this;
    }

    public AsteroidBuilder AddToCurrentAsteroids()
    {
        AsteroidSpawner.Instance.currentAsteroids.Add(asteroidInstance);
        return this;
    }

    public Asteroid Build()
    {
        return asteroidInstance;
    }
}