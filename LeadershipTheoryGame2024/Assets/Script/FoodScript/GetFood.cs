using UnityEngine;
<<<<<<< HEAD
using Gamecore;
=======
using GameCore;
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
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
<<<<<<< HEAD
        if (collision.gameObject.CompareTag("Possessions"))
=======
        if (collision.gameObject.CompareTag("Player"))
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
        {
            isGetFood = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
<<<<<<< HEAD
        if (collision.gameObject.CompareTag("Possessions"))
=======
        if (collision.gameObject.CompareTag("Player"))
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
        {
            isGetFood = false;
        }
    }

<<<<<<< HEAD
    void AddFoodAtPlayer()//∏¯PlayerÃ˙ÿ” ≥ŒÅEƒ◊”ŒÅEÅE
=======
    void AddFoodAtPlayer()//∏¯PlayerÃÌº” ≥ŒÔµƒ◊”ŒÔÃÂ
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
    {
        GameObject go = GameObject.Find("ParentGo");
        Transform parentGo = go.transform;
        if (go != null)
        {
<<<<<<< HEAD
            if (TheGameTool.FindTheChild(go, food_Name) == null)//»Áπ˚Ω«…´…˙Âœ√ª”–’‚∏ˆ◊”ŒÅEÂæÕÃ˙ÿ”…œ»•
=======
            if (TheGameTool.FindTheChild(go, food_Name) == null)//»Áπ˚Ω«…´…Ì…œ√ª”–’‚∏ˆ◊”ŒÔÃÂæÕÃÌº”…œ»•
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
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
<<<<<<< HEAD
            //    Debug.Log("Ω«…´…˙Âœ¥Ê‘⁄"+ food_Name);
=======
            //    Debug.Log("Ω«…´…Ì…œ¥Ê‘⁄"+ food_Name);
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
            //}
        }
        else
        {
            Debug.Log("’“≤ªµΩPlayerChef");
        }
        //GameObject.Destroy(gameObject);
<<<<<<< HEAD
        go.GetComponent<AutoArrangeChildren>().ArrangeChildren();
=======
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
    }   
}
