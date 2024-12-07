using UnityEngine;
using Gamecore;
public class Fish_GetFood : MonoBehaviour
{
    public bool isGetFood = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)&&isGetFood)
        {
            GameObject go = GameObject.Find("PlayerChef");
            Transform parentGo = go.transform;
            if (go != null)
            {
                GameObject child = Instantiate(Resources.Load<GameObject>("Prefabs\\Fish")) as GameObject;
                Transform childGO = child.transform;
                TheGameTool.AddChildToParent(parentGo, childGO);
                child.SetActive(false);
                //Debug.Log("’“µΩPlayerChef");
            }
            else
            {
                Debug.Log("’“≤ªµΩPlayerChef");
            }
            GameObject.Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            isGetFood=true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isGetFood = false;
        }
    }
}
