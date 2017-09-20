using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// this is a UI component that can show a message, icon and button
[RequireComponent(typeof(RectXformMover))]
public class MessageWindow : MonoBehaviour 
{
	public Image messageImage;
	public Text messageText;
	public Text buttonText;

    // sprite for losers
    public Sprite loseIcon;

    // sprite for winners
    public Sprite winIcon;

    // sprite for the level goal
    public Sprite goalIcon;

    public Sprite collectIcon;
    public Sprite timerIcon;
    public Sprite movesIcon;

    public Image goalImage;
    public Text goalText;

    public GameObject collectionGoalLayout;

	public void ShowMessage(Sprite sprite = null, string message = "", string buttonMsg = "start")
	{
		if (messageImage != null) 
		{
			messageImage.sprite = sprite;
		}

        if (messageText != null)
        {
            messageText.text = message;
        }
			
        if (buttonText != null)
        {
            buttonText.text = buttonMsg;
        }
	}

    public void ShowScoreMessage(int scoreGoal)
    {
        string message = "score goal \n" + scoreGoal.ToString();
        ShowMessage(goalIcon, message, "start");
    }

    public void ShowWinMessage()
    {
        ShowMessage(winIcon, "level\ncomplete", "ok");
    }

    public void ShowLoseMessage()
    {
        ShowMessage(loseIcon, "level\nfailed", "ok");
    }

    public void ShowGoal(string caption = "", Sprite icon = null)
    {
        if (goalText != null && caption != "")
        {
            goalText.text = caption;
        }

        if (goalImage != null && icon != null)
        {
            goalImage.sprite = icon;
        }
    }

    public void ShowTimedGoal(int time)
    {
        string caption = time.ToString() + " seconds";
        ShowGoal(caption, timerIcon);
    }

    public void ShowMovesGoal(int moves)
    {
        string caption = moves.ToString() + " moves";
        ShowGoal(caption, movesIcon);
    }

    public void ShowCollectionGoal(bool state = true)
    {
        if (collectionGoalLayout != null)
        {
            collectionGoalLayout.SetActive(state);
        }

        if (state)
        {
            ShowGoal("", collectIcon);
        }
    }


}
