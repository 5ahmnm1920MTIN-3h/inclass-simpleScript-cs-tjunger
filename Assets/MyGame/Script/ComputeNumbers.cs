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
    result.text = resultText;
}

private float AddNumbers()
{
    float tempResult = float.Parse(varA.text) - float.Parse(varB.text);
    return tempResult;
}
}