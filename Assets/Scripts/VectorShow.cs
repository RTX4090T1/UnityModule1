using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class VectorDiffDemo : MonoBehaviour
{
    public TMP_Text resultText; 

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Vector3 a = new Vector3(5, 5, -7);
            Vector3 b = new Vector3(0, 8, -6);
            Vector3 diff = a - b;
            float sqrMagnitude = diff.sqrMagnitude;

            resultText.text = $"(5,5,-7)-(0,8,-6)={diff}\nКвадрат довжини = {sqrMagnitude}";
        }
    }
}