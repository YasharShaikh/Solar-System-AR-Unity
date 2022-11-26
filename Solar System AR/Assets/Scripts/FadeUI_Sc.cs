using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeUI_Sc : MonoBehaviour
{
    public CanvasGroup infoPanel;
    // Start is called before the first frame update
    public void showUI()
    {
        infoPanel.alpha = 1;
    }
    public void hideUI()
    {
        infoPanel.alpha = 0;
    }
}
