using UnityEngine;
using Gamecore;
public class GetFood : MonoBehaviour
{
    public string food_Name;
    string foodLoad;
    bool isGetFood = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foodLoad = "Prefabs\\" + food_Name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isGetFood)
        {
            AddFoodAtPlayer();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Possessions"))
        {
            isGetFood = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Possessions"))
        {
            isGetFood = false;
        }
    }

    void AddFoodAtPlayer()//ｸlayerﾌ晴ﾓﾊｳﾎ・ﾄﾗﾓﾎ・・
    {
        GameObject go = GameObject.Find("ParentGo");
        Transform parentGo = go.transform;
        if (go != null)
        {
            if (TheGameTool.FindTheChild(go, food_Name) == null)//ﾈ郢釭ﾇﾉｫﾉ栁ﾏﾃｻﾓﾐﾕ篋ﾓﾎ・蠕ﾍﾌ晴ﾓﾉﾏﾈ･
            {
                GameObject child = Instantiate(Resources.Load<GameObject>(foodLoad)) as GameObject;
                Transform childGO = child.transform;
                TheGameTool.AddChildToParent(parentGo, childGO);                
                child.transform.name = food_Name;
                TheGameTool.AddTheChildComponent<FoodData>(go, food_Name);              
                child.SetActive(true);
                
                //Debug.Log("ParentGo");
            }
            //else
            //{
            //    Debug.Log("ｽﾇﾉｫﾉ栁ﾏｴ贇ﾚ"+ food_Name);
            //}
        }
        else
        {
            Debug.Log("ﾕﾒｲｻｵｽPlayerChef");
        }
        //GameObject.Destroy(gameObject);
        go.GetComponent<AutoArrangeChildren>().ArrangeChildren();
    }   
}
