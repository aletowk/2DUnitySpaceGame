using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_PlayerPosition : MonoBehaviour
{
    public Text m_xpos;
    public Text m_ypos;

    // Update is called once per frame
    void Update()
    {
        m_xpos.text = Mathf.RoundToInt(PlayerController.G_PlayerControllerInstance.transform.position.x).ToString();
        m_ypos.text = Mathf.RoundToInt(PlayerController.G_PlayerControllerInstance.transform.position.y).ToString();
    }
}
