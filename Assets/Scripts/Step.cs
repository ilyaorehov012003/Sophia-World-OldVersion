using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step : MonoBehaviour
{
    #region Variables

    public string DebugHeaderText;
    public string LocationText;

    public Sprite LocationImage;

    [TextArea(4, 8)]
    public string DescriptionText;

    //[TextArea(4, 6)]
    public string ChoicesText1;

    //[TextArea(4, 6)]
    public string ChoicesText2;

    //[TextArea(4, 6)]
    public string ChoicesText3;

    //[TextArea(4, 6)]
    public string ChoicesText4;

    public int GoToDialoge;

    public StoryScene currentScene;

    public Step[] Choices;

    #endregion
}
