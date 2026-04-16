using System; 
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
public class MouseGameController : MonoBehaviour, IGameController 
{
    public Action FireButtonPressed;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (FireButtonPressed != null)
            {
                FireButtonPressed();
            }
        }
    }
}
