using UnityEngine;
using UnityEngine.UI;
using TMPro;

    

public class ComputeNumbers : MonoBehaviour
{ 
    [SerializeField] private TextMeshProUGUI result;
    [SerializeField] private TMP_InputField varA;
    [SerializeField] private TMP_InputField varB;
    [SerializeField] private Button btn_reset;
    [SerializeField] private Button btn_sub_Numbers;
    private const string resultText = "Result";

public void SetResult()
{
    // set the result from the SubtractNumbers Method
    result.text = SubstractNumbers().ToString();

    // remove access from inputFields
    varA.interactable = false;
    varB.interactable = false;

    // activate the now needed buttons
    btn_sub_Numbers.interactable = false;
    btn_reset.interactable = true;
}

public void Reset()
{
    // reset the all texts
    varA.text = "0";
    varB.text = "0";
    result.text = resultText;

    // give access to the inputfields again
    varA.interactable = true;
    varB.interactable = true;

    // activate the now needed buttons
    btn_sub_Numbers.interactable = true;
    btn_reset.interactable = false;
}

private float SubstractNumbers()
{
    float tempResult = float.Parse(varA.text) - float.Parse(varB.text);
    return tempResult;
}
}