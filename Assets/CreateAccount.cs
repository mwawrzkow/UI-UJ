using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAccount : PanelInstanceModel
{
    // Start is called before the first frame update
    public void OnSingup()
    {
        parent.SetPanel("Dashboard");
    }
}
