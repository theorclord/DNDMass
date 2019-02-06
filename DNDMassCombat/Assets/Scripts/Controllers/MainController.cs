using Classes;
using interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

  public GameObject CharName;

  public GameObject ActionHolderPrefab;

  public GameObject ActionHolder;

  public GameObject PrefabPanel;

  // Use this for initialization
  void Start () {
    Character cha1 = new Character(CharacterType.Soldier);
    CharName.GetComponent<Text>().text = cha1.Type.ToString();
    AddActionPanel(cha1.Actions);

    UpdateActionPanel(ActionHolderPrefab, cha1.Actions[0]);
  }
	
	// Update is called once per frame
	void Update () {
		
	}

  private void AddActionPanel(List<IAction> actions)
  {
    for(int i=0; i< actions.Count; i++)
    {
      int count = i;
      GameObject panel = Instantiate(PrefabPanel) as GameObject;
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

  public void AttackClick(int i)
  {
    Debug.Log("AttackClicked from button " + i);
  }
}
