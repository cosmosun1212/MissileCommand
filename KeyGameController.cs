using System; 
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;

public class KeyGameController : MonoBehaviour, IGameController 
{
    public Action FireButtonPressed;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (FireButtonPressed != null)
            {
                FireButtonPressed();
            }
        }
    }
}
