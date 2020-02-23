using UnityEngine;

// Allows us to create an asset with the information here easily from the Unity Editor
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 18)]
    [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    [SerializeField] bool CanQuit = false;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

    public bool CanQuitGame()
    {
        return CanQuit;
    }
}
