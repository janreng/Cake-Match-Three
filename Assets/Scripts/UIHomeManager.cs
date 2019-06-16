using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHomeManager : MonoBehaviour
{
    public static UIHomeManager instance;

    [SerializeField] GameObject map;
    [SerializeField] GameObject panelSelect;
    [SerializeField] GameObject nodes;

    [SerializeField] Button btnPlay;

    Button[] nodeLevel;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(() => OpenMap());
        nodeLevel = nodes.GetComponentsInChildren<Button>();
        foreach(Button node in nodeLevel)
        {
            node.onClick.AddListener(() => OpenPanelSelect());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenMap()
    {
        map.SetActive(true);
    }

    public void OpenPanelSelect()
    {
        panelSelect.SetActive(true);
    }
}
