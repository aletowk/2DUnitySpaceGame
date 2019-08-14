using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum StarTypeEnum
{
    YellowStar = 0,
    BlueGiant_1 = 1,
    BlueGiant_2 = 2,
    RedGiant_1 = 3,
    RedDwarf_1 = 4
}

public class Star
{
    public string m_name;
    public Vector2 m_position;
    public float m_size;
    public int m_starType;

    public int m_planetNumber;

    public List<Planet> m_planetList;


    public void printStarInfo()
    {
        Debug.LogFormat("Star Name   :" + m_name + "\n\r" +
                        "Position    :" + "(  " + m_position.x + "  ;  " + m_position.y + "  )" + "\n\r" +
                        "Type        :" + m_starType);
    }

}
