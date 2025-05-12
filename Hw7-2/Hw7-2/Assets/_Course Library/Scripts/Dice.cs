using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    // Start is called before the first frame update
    public void SwitchDice(){
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
