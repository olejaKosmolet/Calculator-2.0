using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComparisonOfNumbers : MonoBehaviour
{
    [SerializeField] private InputField firstNum;
    [SerializeField] private InputField secondNum;
    [SerializeField] private Text resultOutput;

    private List<float> Conversion(InputField firstNum, InputField secondNum)
    {
        float firstNumber = float.Parse(firstNum.text);
        float secondNuber = float.Parse(secondNum.text);
        List<float> numbers = new List<float>() { firstNumber, secondNuber };

        return numbers;
    }

    public void Comparison()
    {
        List<float> nums = Conversion(firstNum, secondNum);
        float result = 0f;

        if (nums[0] > nums[1])
        {
            result = nums[0];
            resultOutput.text = $"{result}";
        }
        else if (nums[0] < nums[1])
        {
            result = nums[1];
            resultOutput.text = $"{result}";
        }
        else
        {
            resultOutput.text = "Равны";
        }               
    }
}
