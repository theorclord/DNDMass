using Assets.Scripts.Classes;
using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

  // active character
  public GameObject CharName;
  public GameObject ActionHolderPrefab;
  public GameObject ActionHolder;

  // Target characters
  public GameObject CharacterTargetPanel;

  private Character selectedCharater;

  private Character mainChar;

  // Use this for initialization
  void Start () {
    // active character creation
    mainChar = new Character(CharacterType.Soldier);
    CharName.GetComponent<Text>().text = mainChar.Type.ToString();
    AddActionPanel(mainChar.Actions);

    UpdateActionPanel(ActionHolderPrefab, mainChar.Actions[0]);

    // target character creation
    List<Character> charList = new List<Character>();
    charList.Add(new Character(CharacterType.Soldier));
    charList.Add(new Character(CharacterType.Archer));
    charList.Add(new Character(CharacterType.Soldier));

    for(int i = 0; i < charList.Count; i++)
    {
      // Add char to list
      Character curChar = charList[i];
      GameObject CharObj = Instantiate(Resources.Load<GameObject>("prefabs/TarChar"));
      UpdateCharTarPanel(CharObj, charList[i]);
      CharObj.transform.SetParent(CharacterTargetPanel.transform);
      CharObj.GetComponent<Button>().onClick.AddListener(delegate { SelectChar(curChar); });
      //panel.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
      CharObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(CharObj.GetComponent<RectTransform>().sizeDelta.x * i + 10 * i +90, -20.0f);
    }
  }
	
	// Update is called once per frame
	void Update () {
		
	}

  #region actionPanel
  private void AddActionPanel(List<IAction> actions)
  {
    for(int i=0; i< actions.Count; i++)
    {
      int count = i;
      GameObject panel = Instantiate(Resources.Load<GameObject>("prefabs/ActionPanel")) as GameObject;
      UpdateActionPanel(panel, actions[i]);
      panel.transform.SetParent(ActionHolder.transform);
      panel.GetComponent<Button>().onClick.AddListener(delegate { AttackClick(count); });
      //panel.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
      panel.GetComponent<RectTransform>().anchoredPosition = new Vector2(panel.GetComponent<RectTransform>().sizeDelta.x * i + 10 * i, 0.0f);
    }
    
  }

  private void UpdateActionPanel(GameObject panel, IAction action)
  {
    // Name of action
    panel.transform.GetChild(0).GetComponent<Text>().text = action.Name;
    // Description of action 
    panel.transform.GetChild(1).GetComponent<Text>().text = action.Description;
  }
  #endregion

  private void UpdateCharTarPanel(GameObject charObj, Character charTar)
  {
    // Name of char
    charObj.transform.GetChild(0).GetComponent<Text>().text = charTar.Name;
  }

  public void AttackClick(int i)
  {
    Debug.Log("AttackClicked from button " + i);
    if (selectedCharater != null)
    {
      mainChar.Actions[i].ExecuteAction(new TargetObject() { TargetCharacter = selectedCharater });
      Debug.Log("Selected char remaining hit points: " + selectedCharater.HitpointsCurrent);
    }
  }

  public void SelectChar(Character charObj)
  {
    selectedCharater = charObj;
    Debug.Log("Selected Character " + charObj.Name);
  }
}
