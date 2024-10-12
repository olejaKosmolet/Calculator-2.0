using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    [SerializeField] private InputField firstNum;
    [SerializeField] private InputField secondNum;
    [SerializeField] private Text resultOutput;

    private List<float> ReturnNumbers(InputField firstNum, InputField secondNum)
    {
        float firstNumber = float.Parse(firstNum.text);
        float secondNuber = float.Parse(secondNum.text);
        List<float> numbers = new List<float>() { firstNumber, secondNuber };

        return numbers;
    }

    public void AddNumbers()
    {
        List<float> nums = ReturnNumbers(firstNum, secondNum);
        float result = nums[0] + nums[1];
        resultOutput.text = $"{result}";
    }

    public void SubtractNumbers()
    {
        List<float> nums = ReturnNumbers(firstNum, secondNum);
        float result = nums[0] - nums[1];
        resultOutput.text = $"{result}";
    }

    public void MultiplyNumbers()
    {
        List<float> nums = ReturnNumbers(firstNum, secondNum);
        float result = nums[0] * nums[1];
        resultOutput.text = $"{result}";
    }

    public void DivideNumbers()
    {
        List<float> nums = ReturnNumbers(firstNum, secondNum);

        if (nums[1] != 0)
        {
            float result = nums[0] / nums[1];
            resultOutput.text = $"{result}";
        }
        else resultOutput.text = "На ноль делить нельзя!";
    }
}
