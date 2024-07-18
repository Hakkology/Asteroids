using System;
using UnityEngine;
using UnityEngine.Events;

public class VFXManager : BaseManager<VFXManager> {
    public ParticleSystem explosionPrefab;
    public event Action<Transform> OnExplosionRequested;

    protected override void Awake() => base.Awake();
    void Start() => OnExplosionRequested += TriggerExplosion;
    void OnDestroy() => OnExplosionRequested -= TriggerExplosion;
    public void RequestExplosion(Transform location) => OnExplosionRequested?.Invoke(location);
    public void TriggerExplosion(Transform location)
    {
        ParticleSystem explosion = Instantiate(explosionPrefab, location.position, Quaternion.identity);
        explosion.Play();
        Destroy(explosion.gameObject, explosion.main.duration);
    }
}