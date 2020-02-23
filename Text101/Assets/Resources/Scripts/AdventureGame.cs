using UnityEngine;
using TMPro;
using System;

public class AdventureGame : MonoBehaviour
{
    #region Serialized Variables
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] State startingState;
    [SerializeField] string titleString;
    #endregion

    State state;


    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        titleText.text = titleString;
        storyText.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
            storyText.text = state.GetStateStory();
        }
    }
}
