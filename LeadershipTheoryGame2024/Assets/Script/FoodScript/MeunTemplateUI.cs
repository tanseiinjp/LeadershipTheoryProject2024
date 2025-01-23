using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class MeunTemplateUI : MonoBehaviour
{
    [SerializeField] private Text foodName_M;
    [SerializeField] private Transform foodListParent;
    [SerializeField] private Image iconUITemp;
    [SerializeField] private Image foodImage;



    private void Start()
    {
        iconUITemp.gameObject.SetActive(false);
    }
    public void UpdateUI(CombineMeunOS cmOS)//¸üÐÂUI
    {
        foodName_M.text = cmOS.name;
        foodImage.sprite = cmOS.foodSprite;
        foreach (FoodMeunOS fmOS in cmOS.foodMeunOsList)
        {
            Image newIcon = GameObject.Instantiate(iconUITemp);
            newIcon.transform.SetParent(foodListParent);
            newIcon.sprite = fmOS.sprite;
            newIcon.gameObject.SetActive(true);
        }

    }
}
