using UnityEngine;

public class TouchController
{
    private Player player;
    private Rect leftJoystickArea;
    private Rect thrustArea;

    public TouchController(Player player)
    {
        this.player = player;
        leftJoystickArea = new Rect(0, 0, Screen.width * 0.15f, Screen.height * 0.15f);
        thrustArea = new Rect(0, 0, Screen.width, Screen.height);
    }

    public void HandleTouchInput()
    {
        player.turning = 0f;

        foreach (Touch touch in Input.touches)
        {
            Vector2 touchPosition = touch.position;
            player.thrusting = thrustArea.Contains(touchPosition) && touch.phase != TouchPhase.Ended;

            if (leftJoystickArea.Contains(touchPosition))
            {
                if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
                {
                    Vector2 joystickDirection = touchPosition - new Vector2(leftJoystickArea.x + leftJoystickArea.width / 2, leftJoystickArea.y + leftJoystickArea.height / 2);
                    joystickDirection = joystickDirection.normalized;
                    // Joystick hareketinin yönüne göre dönüş değerini ayarla
                    player.turning = joystickDirection.x < 0 ? 1.0f : -1.0f;
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    player.turning = 0.0f;  // Dönüşü sıfırla
                }
            }
            else if (thrustArea.Contains(touchPosition) && touch.phase != TouchPhase.Ended)
            {
                player.thrusting = true;  // Thrusting'i aktif et
            }
        }
    }
}
