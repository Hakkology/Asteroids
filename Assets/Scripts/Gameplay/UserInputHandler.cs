using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputHandler : MonoBehaviour
{
    public delegate void TapAction(Touch t);
    public static event TapAction OnTap;

    public delegate void PanBeganAction(Touch t);
    public static event PanBeganAction OnPanBegan;

    public delegate void PanHeldAction(Touch t);
    public static event TapAction OnPanHeld;

    public float tapMaxMovement = 50f;

    private Vector2 movement;
    private bool tapGestureFailed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];
            if (touch.phase == TouchPhase.Began)
            {
                movement = Vector2.zero;
            }
            else if(touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                movement += touch.deltaPosition;
                if (movement.magnitude > tapMaxMovement)
                {
                    tapGestureFailed = true;
                }
            }
            else
            {
                if (!tapGestureFailed)
                {
                    if (OnTap != null) OnTap(touch);
                }
                tapGestureFailed = false;
            }
        }
    }
}
