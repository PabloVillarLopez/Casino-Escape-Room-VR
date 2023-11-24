using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlesManager : MonoBehaviour
{
    public bool phase1Completed;
    public bool phase2Completed;
    public bool phase3Completed;
    public bool phase4Completed;
    public bool phase5Completed;
    public bool phase6Completed;

    public enum Phases { 
        Phase1, //Colocar las bolas de billar
        Phase2, //Patrón o combinación con cartas
        Phase3, //Ver algo con las gafas de vista
        Phase4, //Mover manecillas del reloj
        Phase5, //Romper electricidad con alcohol
        Phase6 //Colocar bombilla en un lugar oscuro para ver algo escondido
    };

    //Phase1
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public GameObject ball6;
    public GameObject ball7;
    public GameObject ball8;
    public GameObject ball9;
    public GameObject ball10;
    public GameObject ball11;
    public GameObject ball12;
    public GameObject ball13;
    public GameObject ball14;
    public GameObject ball15;
    public GameObject ball16;
    public Transform ball1CorrectPosition;
    public Transform ball2CorrectPosition;
    public Transform ball3CorrectPosition;
    public Transform ball4CorrectPosition;
    public Transform ball5CorrectPosition;
    public Transform ball6CorrectPosition;
    public Transform ball7CorrectPosition;
    public Transform ball8CorrectPosition;
    public Transform ball9CorrectPosition;
    public Transform ball10CorrectPosition;
    public Transform ball11CorrectPosition;
    public Transform ball12CorrectPosition;
    public Transform ball13CorrectPosition;
    public Transform ball14CorrectPosition;
    public Transform ball15CorrectPosition;
    public Transform ball16CorrectPosition;

    //Phase2

    //Phase3
    public bool glassesOn;
    public GameObject hiddenObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
