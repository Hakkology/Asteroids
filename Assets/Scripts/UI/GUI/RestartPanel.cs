using TMPro;

public class RestartPanel : UIPanel
{
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI highScoreText;

    public override void OpenPanel()
    {
        currentScoreText.text = "SCORE: " + GameManager.Instance.GetScore();
        highScoreText.text = "HIGHSCORE: " + GameManager.Instance.GetScore(); // Implement GetHighScore method in GameManager
        base.OpenPanel();
    }
}


