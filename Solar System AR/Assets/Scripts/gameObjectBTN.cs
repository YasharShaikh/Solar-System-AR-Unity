using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class gameObjectBTN : MonoBehaviour
{
    public GameObject gbAsBTN;
    public UnityEvent OnClick = new UnityEvent();

    [Header("Child")]
    public GameObject InfoPanel;
    bool isInfoPanelOpen;

    // Start is called before the first frame update
    void Start()
    {
        gbAsBTN = this.gameObject;
        InfoPanel = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject == gameObject)
            {
                isInfoPanelOpen = !isInfoPanelOpen;
                InfoPanel.SetActive(isInfoPanelOpen);
                Debug.Log("HIT");
                OnClick.Invoke();
            }
            else
            {
                InfoPanel.SetActive(false);
            }


        }
    }
}
