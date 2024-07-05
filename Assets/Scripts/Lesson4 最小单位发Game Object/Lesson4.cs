using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
        //gameobject里面的静态方法
        //查找对象
        GameObject obj2 = GameObject.Find("Main Camera");
        if (obj2 != null)
        {
            print(obj2.name);
        }
        else
        {
            print("Main Camera Cant Find");
        }

        GameObject obj3= GameObject.FindWithTag("Player");
        if (obj3 != null)
        {
            print("根据tag找对象" +obj3.name);
        }
        else
        {
            print("Cant Find GameObject with Tag Player");
        }
        //查找多个对象
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print("找到的Player tag的GameObject" + +objs.Length);

        Lesson4 lesson4= GameObject.FindObjectOfType<Lesson4>();
        print(lesson4.gameObject.name);

        GameObject obj5= GameObject.Instantiate(obj);
        DontDestroyOnLoad(this.gameObject);
        //gmaeobject中的成员方法
        GameObject obj6 = new GameObject();
        GameObject obj7 = new GameObject("New Object");
        GameObject obj8 = new GameObject("New Object with scripts",typeof(Lesson4));
        Lesson1 lesson1= obj6.AddComponent(typeof(Lesson1)) as Lesson1;
        Lesson1 lesson2= obj6.AddComponent<Lesson1>();

        this.gameObject.CompareTag("Player");
        obj6.SetActive(false);
        
        gameObject.SendMessage("TestFun");
        gameObject.SendMessage("TestFun",9999999);
        GameObject.CreatePrimitive(PrimitiveType.Cube);

    }

    void TestFun()
    {
        print("Test!!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void TestFun(int a)
    {
        print(a);
    }
}
