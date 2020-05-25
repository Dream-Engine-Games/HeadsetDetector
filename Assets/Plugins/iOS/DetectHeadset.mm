#import <AVFoundation/AVFoundation.h>

extern "C" {

	int _Detect() {
		
        AVAudioSessionRouteDescription* route = [[AVAudioSession sharedInstance] currentRoute];
        
        for (AVAudioSessionPortDescription* desc in [route outputs]) {
            if ([[desc portType] isEqualToString:AVAudioSessionPortHeadphones])
                return 1;
            if ([[desc portType] isEqualToString:AVAudioSessionPortHeadsetMic])
                return 1;
            if ([[desc portType] isEqualToString:AVAudioSessionPortLineOut])
                return 1;
            if ([[desc portType] isEqualToString:AVAudioSessionPortUSBAudio])
                return 1;

            if ([[desc portType] isEqualToString:AVAudioSessionPortBluetoothHFP])
                return 2;
            if ([[desc portType] isEqualToString:AVAudioSessionPortBluetoothA2DP])
                return 2;
            if ([[desc portType] isEqualToString:AVAudioSessionPortBluetoothLE])
                return 2;
        }
        
        return 0;
        
	}
	
}
