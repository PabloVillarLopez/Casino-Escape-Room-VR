using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PuzzlesManager : MonoBehaviour
{
    public bool phase1Completed, phase2Completed, phase3Completed, phase4Completed, phase5Completed, phase6Completed;
    public bool phase1Started, phase2Started, phase3Started, phase4Started, phase5Started, phase6Started;

    public enum Phases { 
        Phase1, //Colocar las bolas de billar
        Phase2, //Patrón o combinación con cartas
        Phase3, //Ver algo con las gafas de vista
        Phase4, //Mover manecillas del reloj
        Phase5, //Romper electricidad con alcohol
        Phase6 //Colocar bombilla en un lugar oscuro para ver algo escondido
    };

    private Phases currentPhase;

    //Phase1
    public GameObject ball1, ball2, ball3, ball4, ball5, ball6, ball7, ball8, ball9, ball10, ball11, ball12, ball13, ball14, ball15, ball16;
    public Transform ball1CorrectPosition, ball2CorrectPosition, ball3CorrectPosition, ball4CorrectPosition, ball5CorrectPosition, ball6CorrectPosition;
    public Transform ball7CorrectPosition, ball8CorrectPosition, ball9CorrectPosition, ball10CorrectPosition, ball11CorrectPosition, ball12CorrectPosition;
    public Transform ball13CorrectPosition, ball14CorrectPosition, ball15CorrectPosition, ball16CorrectPosition;

    //Phase2

    //Phase3
    public GameObject hiddenObject;

    //Phase4
    public GameObject clock;
    public GameObject clockHand1;
    public GameObject clockHand2;

    //Phase5
    public GameObject lightObject;
    private Light lightComponent;
    public GameObject shadowHiddenObject;

    //Phase6
    public GameObject lightHiddenObject;

    // Start is called before the first frame update
    void Start()
    {
        currentPhase = Phases.Phase1;
        phase1Started = true;
        hiddenObject.SetActive(false);
        lightComponent = lightObject.GetComponent<Light>();
        shadowHiddenObject.SetActive(false);
        lightHiddenObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentPhase)
        {
            case Phases.Phase1: //Comprobar boleanos de si las bolas están bien colocadas
                break;
            case Phases.Phase2: //Poner cartas en mesa de billar y poner en colliders cartas específicas de forma que hagan patrón
                phase1Started = false;
                phase2Started = true;
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
            case Phases.Phase4: //Ampliar reloj, con mandos cambiar rotación de las manecillas
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

                if (LightbulbPositioning.lightbulbWellPlaced)
                {
                    //Algo pasa, encender la luz?
                }
                break;
            default:
                break;
        }
    }
}
