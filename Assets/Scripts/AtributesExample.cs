using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributesExample : MonoBehaviour
{

    

    [Space]
    [Header("numbers")]
    public int score;
    [SerializeField]
    private int money;

    [Space]
    [Header("Other values")]
    [SerializeField]
    private string password;

    [Space]
    [Header("Slides")]

    [Range(0,5)] private string lives;

    [Min(0)]     private string numberRan;

    [TextArea] public string dialogue;


    [Header("Tools")]
    [Tooltip("Esta es la id del jugador, cambiar con ciudad")]
    [SerializeField] private string id;

    [ContextMenu("Call Function")]
    public void MyFunc()
    {
        Debug.Log("MyFunc has been activated!!");
    }
}
