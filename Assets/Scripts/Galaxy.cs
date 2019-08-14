using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy : MonoBehaviour
{
    public int m_numberOfStars = 2;
    public float m_size = 10f;
    public float m_minDistanceFromCenter = 2f;
    public int m_seed = 1;


    List<GameObject> m_starList;

    // Start is called before the first frame update
    void Start()
    {
        m_starList = new List<GameObject>();
        CreateGalaxy();
        Debug.LogFormat("Created " + m_numberOfStars + "Stars");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateGalaxy()
    {
        float distance = 0;
        float angle = 0f;
        UnityEngine.Random.InitState(m_seed);
        Vector2 cartesianPosition = new Vector2();
        GameObject tmpGO;

        for(int i = 0; i < m_numberOfStars; i++)
        {
            distance = UnityEngine.Random.Range(m_minDistanceFromCenter,m_size);
            angle = UnityEngine.Random.Range(0f, 2 * Mathf.PI);

            cartesianPosition.Set(distance * Mathf.Cos(angle), distance * Mathf.Sin(angle));

            tmpGO = Instantiate(Resources.Load("Prefabs/Stars/YellowStar"), this.transform) as GameObject;
            tmpGO.transform.position = cartesianPosition;

            if (!IsPositionAvailable(cartesianPosition))
            {
                i--;
            }

            m_starList.Add(tmpGO);
        }
    }

    bool IsPositionAvailable(Vector3 position)
    {
        for(int i = 0; i < m_starList.ToArray().Length; i++)
        {
            if (position == m_starList.ToArray()[i].transform.position)
                return false;
        }
        return true;
    }
}
