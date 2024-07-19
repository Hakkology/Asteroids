using TMPro;
using UnityEngine;

public class HUDManager : BaseManager<HUDManager> {

    public TextMeshProUGUI livesText;
    public TextMeshProUGUI scoreText;
    public void UpdateLivesText(int lives){
        livesText.text = "x" + lives;
    }
    public void UpdateScoreText(int score){
        scoreText.text = score.ToString();
    }
}