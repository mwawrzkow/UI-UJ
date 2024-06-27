using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginPanel : PanelInstanceModel
{
    // Start is called before the first frame update

    public void OnLoginPressed()
    {
        parent.SetPanel("Dashboard");
    }

    public void OnCreateAnAccountPressed()
    {
        parent.SetPanel("Register");
    }
}
