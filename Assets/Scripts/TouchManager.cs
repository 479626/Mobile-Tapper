using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public TextManager textManager;

    private void Update()
    {
        AddAdditionalCount();
    }

    public void AddAdditionalCount()
    {
        if (!textManager.canClick) return;
        Touch touch = Input.GetTouch(0);

        if (touch.tapCount == 1)
        {
            textManager.AddToCount();
        }
        else if (touch.tapCount == 2 && textManager.count != 0)
        {
            textManager.RemoveFromCount();
        }
    }
}
