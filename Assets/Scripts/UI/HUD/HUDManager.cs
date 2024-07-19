using TMPro;
using UnityEngine;

public class HUDManager : BaseManager<HUDManager> {

    public TextMeshProUGUI livesText;
    public void UpdateLivesText(int lives){
        livesText.text = "x" + lives;
    }
}