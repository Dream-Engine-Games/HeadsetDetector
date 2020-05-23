using UnityEngine;

namespace DEG.HeadsetDetector
{
	public static class DEGHDIos
	{

#if UNITY_IOS && !UNITY_EDITOR
		[DllImport ("__Internal")]
		static private extern int _Detect();
#endif

		public static bool Initialized => true;

		public static void Initialize()
		{

		}

		public static int Detect()
		{
#if UNITY_IOS && !UNITY_EDITOR
			return _Detect();
#endif
			return 0;
		}
	}
}