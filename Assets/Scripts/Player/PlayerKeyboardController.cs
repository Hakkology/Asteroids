using UnityEngine;
using UnityEngine.UI;

public class KeyboardController
{
    private Player player;


    public KeyboardController(Player player)
    {
        this.player = player;

    }


    public void HandleKeyboardInput()
    {
        player.thrusting = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        player.ChangeThrust(player.thrusting);
        
        player.turning = 0f;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            player.turning = 1.0f;
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            player.turning = -1.0f;
        
        player.ChangeTurn(player.turning);

        if (Input.GetKeyDown(KeyCode.F))
        {
            player.Shoot();
        }
    }
}
