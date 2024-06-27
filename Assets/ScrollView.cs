using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollView : PanelInstanceModel
{
    // Start is called before the first frame update
    public void OnCardClick()
    {
        parent.SetPanel("GameCheck");
    }
}
