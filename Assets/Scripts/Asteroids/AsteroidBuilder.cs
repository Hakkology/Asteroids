using UnityEngine;

public class AsteroidBuilder
{
    private Asteroid asteroidInstance;
    private AsteroidSpawner spawner;

    public AsteroidBuilder(AsteroidSpawner asteroidSpawner)
    {
        spawner = asteroidSpawner;
    }

    public AsteroidBuilder InstantiateAsteroid(Vector3 position, Quaternion rotation)
    {
        asteroidInstance = MonoBehaviour.Instantiate(spawner.asteroidPrefab, position, rotation);
        asteroidInstance.gameObject.SetActive(true);
        return this;
    }

    public AsteroidBuilder SetSize(float size)
    {
        asteroidInstance.size = size * asteroidInstance.transform.localScale.x;
        asteroidInstance.transform.localScale = Vector3.one * size;
        return this;
    }

    public AsteroidBuilder SetTrajectory(Vector2 direction)
    {
        asteroidInstance.SetTrajectory(direction);
        return this;
    }

    public Asteroid Build()
    {
        return asteroidInstance;
    }
}