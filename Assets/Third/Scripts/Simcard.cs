using UnityEngine;

public class Simcard : MonoBehaviour
{
    private static Simcard instance;
    public static Simcard Instance
    {
        get
        {
            if(!instance)
            {
                GameObject simcardGO = new GameObject("Simcard", typeof(Simcard));

                instance = simcardGO.GetComponent<Simcard>();

                DontDestroyOnLoad(simcardGO);
            }

            return instance;
        }
    }

    public string GetTwoSmallLetterCountryCodeISO()
    {
        #if UNITY_ANDROID && !UNITY_EDITOR

        AndroidJavaClass jcUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

        AndroidJavaObject joUnityActivity = jcUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        AndroidJavaObject joAndroidPluginAccess = new AndroidJavaObject("com.flipmorris.simcardinfo.SimcardManager");

        return joAndroidPluginAccess.Call<string>("GetTwoSmallLetterCountryCodeISO", joUnityActivity);

        #else

        return string.Empty;

        #endif
    }
}
