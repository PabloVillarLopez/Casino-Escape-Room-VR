using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueScript : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] lines;
    public float textSpeed = 0.1f;
    int index;
    public GameObject dialoguePanel;
    public GameObject questionMark;
    public static bool didDialogueStart;
    private bool isPlayerInRange;

    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = string.Empty;
        dialoguePanel.SetActive(false);
        questionMark.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!didDialogueStart)
            {
                dialogueText.text = string.Empty;
                StartDialogue();
            }
            else if (dialogueText.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        index = 0;

        StartCoroutine(WriteLine());
    }

    IEnumerator WriteLine()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            dialogueText.text += letter;

            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(WriteLine());
        }
        else
        {
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
            //Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            isPlayerInRange = true;
            //questionMark.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            isPlayerInRange = false;
            //questionMark.SetActive(false);
        }

    }
}
