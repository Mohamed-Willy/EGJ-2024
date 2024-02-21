using System.Collections;
using UnityEngine;
using UnityEngine.UI;
enum Speakers
{
    PIGGY
}
[System.Serializable]
struct Character
{
    public string name;
    public Sprite characterImage;
}
[System.Serializable]
struct DialogueEntery
{
    public string text;
    public Speakers speaker;
}
public class DialogueSystem : MonoBehaviour
{
    [Header("Dialogue")]
    [SerializeField] private Character[] characters;
    [SerializeField] private DialogueEntery[] entries;
    [SerializeField] private float timeBetweenCharacters;
    [SerializeField] private float timeBetweenEntries;
    [Header("Canvas")]
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] Image speakerImage;
    [SerializeField] Text speakerName;
    [SerializeField] Text dialogueText;
    int index = 0;
    private void OnEnable()
    {
        ShowDialogue();
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
    IEnumerator TextDisplay()
    {
        dialogueText.text = string.Empty;
        if (index < entries.Length)
        {
            int speakerIndex = (int)entries[index].speaker;
            speakerName.text = characters[speakerIndex].name;
            if (characters[speakerIndex].characterImage != null)
            {
                speakerImage.sprite = characters[speakerIndex].characterImage;
            }
            else
            {
                Debug.Log("no sprite");
            }
            foreach (char newChar in entries[index].text)
            {
                dialogueText.text += newChar;
                yield return new WaitForSeconds(timeBetweenCharacters);
            }
            index++;
            Invoke(nameof(ShowDialogue), timeBetweenEntries);
        }
        else
        {
            StopAllCoroutines();
        }
    }
    private void ShowDialogue()
    {
        dialoguePanel.SetActive(true);
        StartCoroutine(TextDisplay());
    }
}