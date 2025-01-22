using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class MeunUI : MonoBehaviour
{
    [SerializeField] private Transform meunParent;
    [SerializeField] private MeunTemplateUI meunTemplateUI;

    private void Start()
    {
        meunTemplateUI.gameObject.SetActive(false);
        OrderManager.instance.OnMeunorderSpawend += OrderManager_OnMeunorderSpawend;
        OrderManager.instance.OnOrderFinished += OrderManger_OnOrderFinished;
    }

    private void OrderManger_OnOrderFinished(object sender, System.EventArgs e)
    {
        UpdateUI();
    }

    private void OrderManager_OnMeunorderSpawend(object sender, System.EventArgs e)
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        foreach (Transform child in meunParent)
        {
            if (child != meunTemplateUI.transform)
            {
                Destroy(child.gameObject);
            }
        }

        List<CombineMeunOS> combineMeunOsList = OrderManager.instance.GetOrderList();
        foreach (CombineMeunOS cmOS in combineMeunOsList)
        {
            MeunTemplateUI mtUI = GameObject.Instantiate(meunTemplateUI);
            mtUI.transform.SetParent(meunParent);
            mtUI.gameObject.SetActive(true);
            mtUI.UpdateUI(cmOS);
        }
    }
}
