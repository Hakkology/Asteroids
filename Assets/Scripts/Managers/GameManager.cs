using System;
using System.Collections;
using UnityEngine;

public class GameManager : BaseManager<GameManager>
{
    public Player player;
    public int lives = 3;
    public float respawnTime = 3;
    private int score = 0;

    protected override void Awake()
    {
        base.Awake();
        player.onPlayerDied.AddListener(PlayerDied);
    }

    void Start() {
        HUDManager.Instance.UpdateLivesText(lives);
    }

    void PlayerDied()
    {
        lives--;
        HUDManager.Instance.UpdateLivesText(lives);
        VFXManager.Instance.TriggerExplosion(player.transform);

        if (lives <= 0)
            GameOver();
        else
            Invoke(nameof(Respawn), respawnTime);
    }

    public int GetScore() => score;
    public void AddScore(int amount) => score += amount;
    private void Respawn()
    {
        player.transform.position = Vector3.zero;
        player.gameObject.layer = LayerMask.NameToLayer("Invulnerable");
        player.gameObject.SetActive(true);
        StartCoroutine(PlayerCollisionsOn());
    }

    private IEnumerator PlayerCollisionsOn()
    {
        yield return new WaitForSeconds(2);
        player.gameObject.layer = LayerMask.NameToLayer("Player");
    }

    private void GameOver()
    {
        GUIManager.Instance.OpenRestartPanel();
    }
}
