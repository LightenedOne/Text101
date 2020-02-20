using UnityEngine;
using TMPro;

public class  AdventureGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        titleText.text = ("No longer placeholder.");
        storyText.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
