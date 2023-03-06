using UnityEngine;

public static class NumButtonHelper
{
    #region Variables

    private static readonly KeyCode[] AlphaKeys = new[]
    {
        KeyCode.Alpha0,
        KeyCode.Alpha1,
        KeyCode.Alpha2,
        KeyCode.Alpha3,
        KeyCode.Alpha4,
        KeyCode.Alpha5,
        KeyCode.Alpha6,
        KeyCode.Alpha7,
        KeyCode.Alpha8,
        KeyCode.Alpha9
    };

    private static readonly KeyCode[] KeyPadKeys = new[]
    {
        KeyCode.Keypad0,
        KeyCode.Keypad1,
        KeyCode.Keypad2,
        KeyCode.Keypad3,
        KeyCode.Keypad4,
        KeyCode.Keypad5,
        KeyCode.Keypad6,
        KeyCode.Keypad7,
        KeyCode.Keypad8,
        KeyCode.Keypad9,
    };

    #endregion


    #region Public metods

    public static int GetPressedButtonIndex()
    {
        for (int i = 0; i < AlphaKeys.Length; i++)
        {
            if (Input.GetKeyDown(AlphaKeys[i]) || Input.GetKeyDown(KeyPadKeys[i]))
                return i;
        }

        if (Button1.buttonStatus1 == 1)
        {
            Button1.buttonStatus1 = 0;
            return 1;
        }

        if (Button2.buttonStatus2 == 2)
        {
            Button2.buttonStatus2 = 0;
            return 2;
        }

        if (Button3.buttonStatus3 == 3)
        {
            Button3.buttonStatus3 = 0;
            return 3;
        }

        if (Button4.buttonStatus4 == 4)
        {
            Button4.buttonStatus4 = 0;
            return 4;
        }

        return -1;
    }

    #endregion
}