using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Galaxy : MonoBehaviour
{
    public static Galaxy GalaxyInstance;
    public int m_numberOfStars = 2;
    public float m_size = 10f;
    public float m_minDistanceFromCenter = 15f;
    public int m_seed = 1;
    public int crash_creation = 0;
    public float m_minimalDistanceBetweenStars = 3f;
    public Dictionary<Star, GameObject> m_starToObjectMap;

    bool m_isActive;


    public GameObject m_starInfoPopUp;

    private void OnEnable()
    {
        GalaxyInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        m_starToObjectMap = new Dictionary<Star, GameObject>();
        m_isActive = true;
        CreateGalaxy();
        Debug.LogFormat("Created " + m_numberOfStars + "Stars");
    }

    // Update is called once per frame
    void Update()
    {
        if(m_isActive)
        {
            CheckStarClicked();
        }
    }
    private void CheckStarClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                Star starClicked = returnStarFromGameobject(hit.collider.gameObject);
                starClicked.printStarInfo();
                printPopUp(starClicked);
            }
        }
    }
    public void printPopUp(Star star)
    {
        Image[] fields = m_starInfoPopUp.GetComponentsInChildren<Image>();
        Text[] tmpTxt = fields[1].GetComponentsInChildren<Text>();
        tmpTxt[1].text = star.m_name;

        tmpTxt = fields[2].GetComponentsInChildren<Text>();
        tmpTxt[1].text = string.Format("(  {0} ; {1}  )", Mathf.RoundToInt(star.m_position.x), Mathf.RoundToInt(star.m_position.y));

        tmpTxt = fields[3].GetComponentsInChildren<Text>();
        tmpTxt[1].text = star.m_starType.ToString();

        m_starInfoPopUp.SetActive(true);

    }
    public Star returnStarFromGameobject(GameObject go)
    {
        if(m_starToObjectMap.ContainsValue(go))
        {
            int index = m_starToObjectMap.Values.ToList().IndexOf(go);
            return m_starToObjectMap.Keys.ToList()[index];
        }
        return null;
    }

    private string[] G_PREFABS_NAMES = new string[] { "Prefabs/Stars/YellowStar",
                                                      "Prefabs/Stars/BlueGiant_1_Prefab",
                                                      "Prefabs/Stars/BlueGiant_2_Prefab",
                                                      "Prefabs/Stars/RedGiant_1_Prefab",
                                                      "Prefabs/Stars/RedDwarf_1_Prefab"};
    void CreateGalaxy()
    {
        UnityEngine.Random.InitState(m_seed);
        GameObject tmpGO;
        

        for(int i = 0; i < m_numberOfStars; i++)
        {
            Star tmpStar = new Star();
            computeStarData(tmpStar);

            if (!IsPositionAvailable(tmpStar.m_position))
            {
                i--;
                crash_creation++;
            }
            else
            {
                tmpGO = Instantiate(Resources.Load(G_PREFABS_NAMES[tmpStar.m_starType]), this.transform) as GameObject;
                tmpGO.transform.position = tmpStar.m_position;
                tmpGO.transform.localScale *= tmpStar.m_size;// Vector3.one * tmpSize
                m_starToObjectMap.Add(tmpStar, tmpGO);
            }
        }
    }

    void computeStarData(Star star)
    {
        float distance = UnityEngine.Random.Range(m_minDistanceFromCenter, m_size);
        float angle = UnityEngine.Random.Range(0f, 2 * Mathf.PI);
        int starNameIndex = UnityEngine.Random.Range(0, Constantes.Starnames.ToArray().Length);

        star.m_name = Constantes.Starnames.ToArray()[starNameIndex];
        Constantes.Starnames.RemoveAt(starNameIndex);

        star.m_position = new Vector2(distance * Mathf.Cos(angle), distance * Mathf.Sin(angle));

        star.m_starType = UnityEngine.Random.Range(0, G_PREFABS_NAMES.Length);
        star.m_size = computeStarSize(star.m_starType);
    }

    float computeStarSize(int index)
    {
        switch(index)
        {
            case (int)StarTypeEnum.YellowStar:
                return UnityEngine.Random.Range(0.8f, 1.2f);
            case (int)StarTypeEnum.BlueGiant_1: 
                return UnityEngine.Random.Range(1.3f, 1.8f);
            case (int)StarTypeEnum.BlueGiant_2: 
                return UnityEngine.Random.Range(1.3f, 1.8f);
            case (int)StarTypeEnum.RedGiant_1:
                return UnityEngine.Random.Range(1.1f, 2.3f);
            case (int)StarTypeEnum.RedDwarf_1:
                return UnityEngine.Random.Range(0.5f, 0.8f);
            default:
                Debug.Log("Error while computing Star size as function of star type returning 0");
                return 0;
        }
    }

    bool IsPositionAvailable(Vector2 position)
    {
        Collider2D[] positionCollider = Physics2D.OverlapCircleAll(position, m_minimalDistanceBetweenStars);
        if(positionCollider.Length == 0)
        {
            return true;
        }
        return false;
        //Vector3 res = new Vector3();
        //for(int i = 0; i < m_starList.ToArray().Length; i++)
        //{
        //    res = position - m_starList.ToArray()[i].transform.position;
        //    if(res.magnitude < m_minimalDistanceBetweenStars)
        //        return false;
        //}
        //return true;
    }
}
