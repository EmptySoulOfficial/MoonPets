using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [Header("- Consumables -")]
    public ConsumableItem[] _consumableItems;
    public int[] _cI_quantity;

    public GameObject[] _cI_menuButtons;

    private int lastIndex = 0;
    private int switchValue = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MenuNext(){
        switchValue = 1;
        MenuSwitch();
    }

    void MenuPrevious(){
        switchValue = -1;
        MenuSwitch();
    }

    void MenuSwitch(){
        for (int i = 0; i < _cI_menuButtons.Length; i++){
            lastIndex += switchValue;
            if(lastIndex < _consumableItems.Length){
                _cI_menuButtons[i].GetComponent<Image>().sprite = _consumableItems[lastIndex].itemImage;
            }else{
                _cI_menuButtons[i].GetComponent<Image>().sprite = null;
            }
        } 
    }
}
