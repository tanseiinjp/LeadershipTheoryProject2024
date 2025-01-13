using UnityEngine;
using GameCore;
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
        if (collision.gameObject.CompareTag("Player"))
        {
            isGetFood = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isGetFood = false;
        }
    }

    void AddFoodAtPlayer()//给Player添加食物的子物体
    {
        GameObject go = GameObject.Find("ParentGo");
        Transform parentGo = go.transform;
        if (go != null)
        {
            if (TheGameTool.FindTheChild(go, food_Name) == null)//如果角色身上没有这个子物体就添加上去
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
            //    Debug.Log("角色身上存在"+ food_Name);
            //}
        }
        else
        {
            Debug.Log("找不到PlayerChef");
        }
        //GameObject.Destroy(gameObject);
    }   
}
