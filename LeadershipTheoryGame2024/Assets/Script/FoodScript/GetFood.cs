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
    void AddFoodAtPlayer()//��Player����ʳ΁E���΁E�E
=======
    void AddFoodAtPlayer()//��Player���ʳ���������
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
    {
        GameObject go = GameObject.Find("ParentGo");
        Transform parentGo = go.transform;
        if (go != null)
        {
<<<<<<< HEAD
            if (TheGameTool.FindTheChild(go, food_Name) == null)//�����ɫ����û�������΁E��������ȥ
=======
            if (TheGameTool.FindTheChild(go, food_Name) == null)//�����ɫ����û�����������������ȥ
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
            //    Debug.Log("��ɫ���ϴ���"+ food_Name);
=======
            //    Debug.Log("��ɫ���ϴ���"+ food_Name);
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
            //}
        }
        else
        {
            Debug.Log("�Ҳ���PlayerChef");
        }
        //GameObject.Destroy(gameObject);
<<<<<<< HEAD
        go.GetComponent<AutoArrangeChildren>().ArrangeChildren();
=======
>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
    }   
}
