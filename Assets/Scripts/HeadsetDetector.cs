namespace DEG.HeadsetDetector
{
	public static class HeadsetDetector
	{
		public enum HeadsetType
		{
			None = 0,
			Wired = 1,
			Bluetooth = 2
		}

		public static void Initialize()
		{
#if UNITY_EDITOR

#elif UNITY_IOS
			DEGHDIos.Initialize();
#elif UNITY_ANDROID
			DEGHDAndroid.Initialize();
#endif
		}

		public static HeadsetType Detect()
		{
#if UNITY_EDITOR
			return HeadsetType.None;
#elif UNITY_IOS
			return (HeadsetType)DEGHDIos.Detect();
#elif UNITY_ANDROID
			return (HeadsetType)DEGHDAndroid.Detect();
#endif
		}
	}
}