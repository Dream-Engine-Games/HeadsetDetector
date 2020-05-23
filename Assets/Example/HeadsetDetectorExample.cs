using UnityEngine;
using UnityEngine.UI;

namespace DEG.HeadsetDetector.Examples
{
	public class HeadsetDetectorExample : MonoBehaviour
	{
		public Text text;
		public Button button;

		// Start is called before the first frame update
		private void Awake()
		{
			button.onClick.AddListener(Refresh);
			Refresh();
		}

		// Update is called once per frame
		private void Refresh()
		{
			text.text = HeadsetDetector.Detect().ToString();
		}
	}
}