using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    private Player player;
    private KeyboardController keyboardController;
    private TouchController touchController;

    void Awake()
    {
        player = GetComponent<Player>();
        keyboardController = new KeyboardController(player);
        touchController = new TouchController(player);
    }

    void Update()
    {
        if (Application.isMobilePlatform)
            touchController.HandleTouchInput();
        else
            keyboardController.HandleKeyboardInput();
    }
}
