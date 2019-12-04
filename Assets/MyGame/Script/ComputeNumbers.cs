using UnityEngine;
using UnityEngine.UI;
using TMPro;

    


public class ComputeNumbers : MonoBehaviour
{ 
    public TextMeshProUGUI result;
    public TMP_InputField varA;
    public TMP_InputField varB;
    public Button btn_reset;
    public Button btn_sub_Numbers;

public void SetResult()
{
    result.text = AddNumbers().ToString();
    varA.interactable = false;
    varB.interactable = false;
    btn_sub_Numbers.interactable = false;
    btn_reset.interactable = true;
}

public void Reset()
{
    varA.text = "0";
    varB.text = "0";
    varA.interactable = true;
    varB.interactable = true;
    btn_sub_Numbers.interactable = true;
    btn_reset.interactable = false;
    result.text = "Result";
}
private float AddNumbers()
{
    float tempResult = float.Parse(varA.text) - float.Parse(varB.text);
    return tempResult;
}
}