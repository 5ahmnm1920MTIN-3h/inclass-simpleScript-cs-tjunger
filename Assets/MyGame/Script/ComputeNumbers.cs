using UnityEngine;
using UnityEngine.UI;
using TMPro;

    

public class ComputeNumbers : MonoBehaviour
{ 
    [SerializeField] private TextMeshProUGUI result;
    [SerializeField] private TMP_InputField InputField1;
    [SerializeField] private TMP_InputField InputField2;
    [SerializeField] private Button btn_reset;
    [SerializeField] private Button btn_sub_Numbers;
    private const string resultText = "Result";

public void SetResult()
{
    // set the result from the SubtractNumbers Method
    result.text = SubstractNumbers().ToString();

    // remove access from inputFields
    InputField1.interactable = false;
    InputField2.interactable = false;

    // activate the now needed buttons
    btn_sub_Numbers.interactable = false;
    btn_reset.interactable = true;
}

public void Reset()
{
    // reset the all texts
    InputField1.text = "";
    InputField2.text = "";
    result.text = resultText;

    // give access to the inputfields again
    InputField1.interactable = true;
    InputField2.interactable = true;

    // activate the now needed buttons
    btn_sub_Numbers.interactable = true;
    btn_reset.interactable = false;
}

private float SubstractNumbers()
{
    float tempResult = float.Parse(InputField1.text) - float.Parse(InputField2.text);
    return tempResult;
}
}