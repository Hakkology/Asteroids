using UnityEngine;
using DG.Tweening;
using TMPro;

public class GUIManager : BaseManager<GUIManager>
{
    public GameObject RestartPanel;
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI highScoreText;

    protected override void Awake()
    {
        base.Awake();
        RestartPanel.transform.localScale = Vector3.zero; // Başlangıçta paneli gizleyin
    }

    public void Open()
    {

        RestartPanel.SetActive(true);
        currentScoreText.text = "SCORE: " + GameManager.Instance.GetScore();
        highScoreText.text = "HIGHSCORE: " + GameManager.Instance.GetScore(); // TO DO IMPLEMENT HIGHSCORE
        
        RestartPanel.transform.DOScale(new Vector3(1, 1, 1), 0.5f)
            .SetEase(Ease.OutBack); 
    }

    public void Close()
    {
        RestartPanel.transform.DOScale(Vector3.zero, 0.5f)
            .SetEase(Ease.InBack) 
            .OnComplete(() => RestartPanel.SetActive(false)); 
    }
}
