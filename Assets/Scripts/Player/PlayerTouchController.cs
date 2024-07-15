using System;
using Unity.Mathematics;
using UnityEngine;

public class TouchController
{
    private Player player;

    public TouchController(Player player)
    {
        this.player = player;
    }

    public void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // İlk dokunmayı al

            Vector2 directionToTouch = Camera.main.ScreenToWorldPoint(touch.position) - player.transform.position;
            float angleDifference = Mathf.DeltaAngle(player.transform.eulerAngles.z, Mathf.Atan2(directionToTouch.y, directionToTouch.x) * Mathf.Rad2Deg - 90f);

            if (Mathf.Abs(angleDifference) > 1f) // Eğer belirli bir açı farkı varsa
                player.turning = MathF.Max(player.turnSpeed, angleDifference / Mathf.Abs(angleDifference)) ;
            
            else
                player.turning = 0;

            player.thrusting = true; 
        }
        else
        {
            player.thrusting = false; 
            player.turning = 0; 
        }
    }
}
