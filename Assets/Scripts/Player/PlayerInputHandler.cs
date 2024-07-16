using UnityEngine;
using UnityEngine.UI;

public class PlayerInputHandler : MonoBehaviour
{
    public Button shootButton;
    
    private Player player;
    private KeyboardController keyboardController;
    private TouchController touchController;

    void Awake()
    {
        player = GetComponent<Player>();
        keyboardController = new KeyboardController(player);
        touchController = new TouchController(player, shootButton);
    }

    void Update()
    {
        if (Application.isMobilePlatform)
            touchController.HandleTouchInput();
        else
            keyboardController.HandleKeyboardInput();
    }
}
