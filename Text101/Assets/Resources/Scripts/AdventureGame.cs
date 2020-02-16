using UnityEngine;
using TMPro;

public class  AdventureGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] TextMeshProUGUI titleText;

    // Start is called before the first frame update
    void Start()
    {
        titleText.text = "No longer placeholder.";
        storyText.text = "I have been edited programmatically. Easy mode.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
