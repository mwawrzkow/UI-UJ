using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashBoard : PanelInstanceModel
{
    public void NavigateToTitle()
    {
        parent.SetPanel("GameTitle");
    }
}
