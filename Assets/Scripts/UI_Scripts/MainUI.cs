using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public GameObject m_starInfoPopUp;
    
    public void CloseStarInfoPopUp()
    {
        m_starInfoPopUp.SetActive(false);
    }

}
