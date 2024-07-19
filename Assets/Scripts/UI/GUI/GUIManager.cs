using UnityEngine;

public class GUIManager : BaseManager<GUIManager>
{
    public UIPanel restartPanel;
    public UIPanel menuPanel;

    protected override void Awake()
    {
        base.Awake();
    }

    public void OpenRestartPanel() => restartPanel.OpenPanel();
    public void CloseRestartPanel() => restartPanel.ClosePanel();
    public void OpenMenuPanel() => menuPanel.OpenPanel();
    public void CloseMenuPanel() => menuPanel.ClosePanel();
    public void ExitGame() => Application.Quit();
    
}

