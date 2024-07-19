using UnityEngine;

public class MenuPanel : UIPanel
{
    public override void OpenPanel()
    {
        base.OpenPanel();
        Time.timeScale = 0;
    }

    public override void ClosePanel()
    {
        base.ClosePanel();
        Time.timeScale = 1;
    }

}