using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class RegEx : MonoBehaviour
{
    public InputField inputText, pattern;
    public Text result;

    public void TestRegex()
    {
        bool match = Regex.IsMatch(inputText.text, pattern.text);
        result.text = match ? "Match!" : "No match";
    }
}
