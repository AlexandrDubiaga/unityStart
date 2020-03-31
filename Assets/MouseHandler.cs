using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour
{
    [Header("Main conf")]
    public int[] Array;
    public float Speed;
    [Header("Second conf")]
    public GameObject Object;
    public TestData Data;
    [Space(100)]
    [SerializeField]
    private List<TestData> Datas;
    [HideInInspector]
    public string Text;

}
[System.Serializable]
public class TestData
{
    public float Heals;
    public float Money;

}