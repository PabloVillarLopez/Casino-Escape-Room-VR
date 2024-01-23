using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class PuzzlesManager : MonoBehaviour
{
    private bool phase1Completed, phase2Completed, phase3Completed;
    //public bool phase4Completed, phase5Completed, phase6Completed;
    private bool phase1Started, phase2Started, phase3Started;
    //public bool phase4Started, phase5Started, phase6Started;
    
    public enum Phases { 
        Phase1, //Colocar las bolas de billar
        Phase2, //Patrón o combinación con cartas
        Phase3, //Ver algo con las gafas de vista
        //Phase4, //Mover manecillas del reloj
        //Phase5, //Romper electricidad con alcohol
        //Phase6 //Colocar bombilla en un lugar oscuro para ver algo escondido
    };

    private Phases currentPhase;

    //Phase1
    //public GameObject ball1, ball2, ball3, ball4, ball5, ball6, ball7, ball8, ball9, ball10, ball11, ball12, ball13, ball14, ball15;
    //public Transform ball1CorrectPosition, ball2CorrectPosition, ball3CorrectPosition, ball4CorrectPosition, ball5CorrectPosition, ball6CorrectPosition;
    //public Transform ball7CorrectPosition, ball8CorrectPosition, ball9CorrectPosition, ball10CorrectPosition, ball11CorrectPosition, ball12CorrectPosition;
    //public Transform ball13CorrectPosition, ball14CorrectPosition, ball15CorrectPosition, ball16CorrectPosition;
    private bool ball1InCorrectPosition, ball2InCorrectPosition, ball3InCorrectPosition, ball4InCorrectPosition, ball5InCorrectPosition, ball6InCorrectPosition;
    private bool ball7InCorrectPosition, ball8InCorrectPosition, ball9InCorrectPosition, ball10InCorrectPosition, ball11InCorrectPosition, ball12InCorrectPosition;
    private bool ball13InCorrectPosition, ball14InCorrectPosition, ball15InCorrectPosition;

    public UnityEvent OnPhase1Completed;

    //Phase2
    //public GameObject card1, card2, card3, card4, card5, card6;
    private bool card1InCorrectPosition, card2InCorrectPosition, card3InCorrectPosition, card4InCorrectPosition, card5InCorrectPosition, card6InCorrectPosition;

    public UnityEvent OnPhase2Completed;

    //Phase3
    
    public UnityEvent OnPhase3Completed;
    //public UnityEvent OnPhase4Completed;

    [Header("Hidden Object revealed by glasses")]
    [Space]
    public GameObject hiddenObject;

    //Phase4
    //public GameObject clock;
    //public GameObject clockHand1;
    //public GameObject clockHand2;

    //Phase5
    //public GameObject lightObject;
    //private Light lightComponent;
    //public GameObject shadowHiddenObject;

    //Phase6
    //public GameObject lightHiddenObject;
    //public bool lightInCorrectPosition;

    // Start is called before the first frame update
    void Start()
    {
        currentPhase = Phases.Phase1;
        phase1Started = true;
        hiddenObject.SetActive(false);
        //lightComponent = lightObject.GetComponent<Light>();
        //shadowHiddenObject.SetActive(false);
        //lightHiddenObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentPhase)
        {
            case Phases.Phase1: //Comprobar boleanos de si las bolas están bien colocadas
                if (ball1InCorrectPosition && ball2InCorrectPosition && ball3InCorrectPosition && ball4InCorrectPosition && ball5InCorrectPosition && ball6InCorrectPosition && 
                    ball7InCorrectPosition && ball8InCorrectPosition && ball9InCorrectPosition && ball10InCorrectPosition && ball11InCorrectPosition && ball12InCorrectPosition && 
                    ball13InCorrectPosition && ball14InCorrectPosition && ball15InCorrectPosition)
                {
                    phase1Completed = true;
                    currentPhase = Phases.Phase2;
                    OnPhase1Completed.Invoke();
                }
                break;
            case Phases.Phase2: //Poner cartas en mesa de billar y poner en colliders cartas específicas de forma que hagan patrón
                phase1Started = false;
                phase2Started = true;

                if (card1InCorrectPosition && card2InCorrectPosition && card3InCorrectPosition && card4InCorrectPosition && card5InCorrectPosition && card6InCorrectPosition)
                {
                    phase2Completed = true;
                    currentPhase = Phases.Phase3;
                    OnPhase2Completed.Invoke();
                }
                break;
            case Phases.Phase3: //Si se ha cogido las gafas glasses on y hiddenObject aparece
                phase2Started = false;
                phase3Started = true;

                if (GlassesScript.glassesOn)
                {
                    hiddenObject.SetActive(true);
                    //Ver que se hace después hasta pasar a siguiente fase
                }
                break;
            /*case Phases.Phase4: //Ampliar reloj, con mandos cambiar rotación de las manecillas
                phase3Started = false;
                phase4Started = true;
                break;
            case Phases.Phase5: //Lanzar botella de alcohol y al colisionar con electricidad romper electricidad, comprobar booleano
                phase4Started = false;
                phase5Started = true;

                if (BottleThrow.collisionWithElectricity) 
                {
                    //Algo pasa, apagar la luz?
                }

                break;
            case Phases.Phase6: //Comprobar booleano colisión entre bombilla y sitio a colocar para encender luz y hacer aparecer objeto
                phase5Started = false;
                phase6Started = true;

                if (LightbulbPositioning.lightbulbWellPlaced) //Forma imprecisa de hacerlo con colliders
                {
                    //Algo pasa, encender la luz?
                }

                if (lightInCorrectPosition) //Forma precisa de hacerlo con XRSocketInteractors
                {
                    //Algo pasa, encender la luz?
                }

                break;*/
            default:
                break;
        }
    }

    //Métodos phase1
    //Métodos para comprobar si cada bola está en su socket correcto o deja de estarlo, luego hay que ponerlos en select entered y select exited del xrsockettaginteractor
    public void Ball1Correct()
    {
        ball1InCorrectPosition = true;
    }

    public void Ball1Incorrect()
    {
        ball1InCorrectPosition = false;
    }

    public void Ball2Correct()
    {
        ball2InCorrectPosition = true;
    }

    public void Ball2Incorrect()
    {
        ball1InCorrectPosition = false;
    }

    public void Ball3Correct()
    {
        ball3InCorrectPosition = true;
    }

    public void Ball3Incorrect()
    {
        ball3InCorrectPosition = false;
    }

    public void Ball4Correct()
    {
        ball4InCorrectPosition = true;
    }

    public void Ball4Incorrect()
    {
        ball4InCorrectPosition = false;
    }

    public void Ball5Correct()
    {
        ball5InCorrectPosition = true;
    }

    public void Ball5Incorrect()
    {
        ball5InCorrectPosition = false;
    }

    public void Ball6Correct()
    {
        ball6InCorrectPosition = true;
    }

    public void Ball6Incorrect()
    {
        ball6InCorrectPosition = false;
    }

    public void Ball7Correct()
    {
        ball7InCorrectPosition = true;
    }

    public void Ball7Incorrect()
    {
        ball7InCorrectPosition = false;
    }

    public void Ball8Correct()
    {
        ball8InCorrectPosition = true;
    }

    public void Ball8Incorrect()
    {
        ball8InCorrectPosition = false;
    }

    public void Ball9Correct()
    {
        ball9InCorrectPosition = true;
    }

    public void Ball9Incorrect()
    {
        ball9InCorrectPosition = false;
    }

    public void Ball10Correct()
    {
        ball10InCorrectPosition = true;
    }

    public void Ball10Incorrect()
    {
        ball10InCorrectPosition = false;
    }

    public void Ball11Correct()
    {
        ball11InCorrectPosition = true;
    }

    public void Ball11Incorrect()
    {
        ball11InCorrectPosition = false;
    }

    public void Ball12Correct()
    {
        ball12InCorrectPosition = true;
    }

    public void Ball12Incorrect()
    {
        ball12InCorrectPosition = false;
    }

    public void Ball13Correct()
    {
        ball13InCorrectPosition = true;
    }

    public void Ball13Incorrect()
    {
        ball13InCorrectPosition = false;
    }

    public void Ball14Correct()
    {
        ball14InCorrectPosition = true;
    }

    public void Ball14Incorrect()
    {
        ball14InCorrectPosition = false;
    }

    public void Ball15Correct()
    {
        ball15InCorrectPosition = true;
    }

    public void Ball15Incorrect()
    {
        ball15InCorrectPosition = false;
    }

    //Métodos phase2
    public void Card1Correct()
    {
        card1InCorrectPosition = true;
    }

    public void Card1Incorrect()
    {
        card1InCorrectPosition = false;
    }

    public void Card2Correct()
    {
        card2InCorrectPosition = true;
    }

    public void Card2Incorrect()
    {
        card2InCorrectPosition = false;
    }

    public void Card3Correct()
    {
        card3InCorrectPosition = true;
    }

    public void Card3Incorrect()
    {
        card3InCorrectPosition = false;
    }

    public void Card4Correct()
    {
        card4InCorrectPosition = true;
    }

    public void Card4Incorrect()
    {
        card4InCorrectPosition = false;
    }

    public void Card5Correct()
    {
        card5InCorrectPosition = true;
    }

    public void Card5Incorrect()
    {
        card5InCorrectPosition = false;
    }

    public void Card6Correct()
    {
        card6InCorrectPosition = true;
    }

    public void Card6Incorrect()
    {
        card6InCorrectPosition = false;
    }

    //Métodos phase 6
    /*public void LightCorrect()
    {
        lightInCorrectPosition = true;
    }

    public void LightIncorrect()
    {
        lightInCorrectPosition = false;
    }*/
}
