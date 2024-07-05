using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_TestEnum
{
    Normal,
    Player,
    Monster,
}
[System.Serializable]
public struct Mystruct
{
    public int age;
    public bool sex;
}
[System.Serializable]
public class MyClass
{
    public int age;
    public bool sex;
}
public class Lesson2 : MonoBehaviour
{
    [SerializeField]private int i1;
    [SerializeField]protected string str1;


    public int publicInt = 10;

    public bool publicBool = true;


    [HideInInspector] public int publicInt2 = 0;

    public int[] array;

    public List<int> list;

    public E_TestEnum type;

    public GameObject gameObject;


    public Dictionary<int, string> dic;

    public Mystruct ms;

    public MyClass mc;
    [Header("基础属性")]
    public int age;

    public bool sex;

    [Header("攻击属性")] 
    public int atk;

    public int def;
    [Tooltip("闪避")]
    public int miss;
    [Space(5)]
    public int crit;

    [Range(0, 10)] public float luck=8.8f;
    [Multiline(10)] public string tips;
    [TextArea(3, 4)] public string mylife;

    [ContextMenuItem("ResetMoney","Test")]
    public int money;
    private void Test()
    {
        money = 99;
    }

    [ContextMenu("TestMethod")]
    private void TestFun()
    {
        print("测试方法被调用");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
