using UnityEngine;
using DG.Tweening;

public class UIPanel : MonoBehaviour, IUIPanel
{
    protected virtual void Awake()
    {
        transform.localScale = Vector3.zero; // Başlangıçta paneli gizleyin
    }

    public virtual void OpenPanel()
    {
        gameObject.SetActive(true);
        transform.DOScale(Vector3.one, 0.5f)
            .SetEase(Ease.OutBack);
    }

    public virtual void ClosePanel()
    {
        transform.DOScale(Vector3.zero, 0.5f)
            .SetEase(Ease.InBack)
            .OnComplete(() => gameObject.SetActive(false));
    }
}
