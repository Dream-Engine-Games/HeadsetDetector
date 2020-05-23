using UnityEngine;

namespace DEG.HeadsetDetector
{
	public static class DEGHDAndroid
	{
		public static bool Initialized { get; private set; } = false;

		private static AndroidJavaClass unityPlayer;
		private static AndroidJavaObject currentActivity;
		private static AndroidJavaObject pluginInstance;

		public static void Initialize()
		{
			if (Initialized)
				return;

			unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
			pluginInstance = new AndroidJavaObject("com.deg.headsetdetector.HeadsetDetector", currentActivity);

			Initialized = true;
		}

		public static int Detect()
		{
			if (!Initialized)
				Initialize();

			return pluginInstance.Call<int>("Detect");
		}
	}
}