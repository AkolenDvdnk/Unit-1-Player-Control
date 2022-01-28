using UnityEngine;
using TMPro;

public class SelectTextControl : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Color32 textColor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.color = textColor;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.color = new Color32(0, 0, 0, 255);
        }
    }
}
