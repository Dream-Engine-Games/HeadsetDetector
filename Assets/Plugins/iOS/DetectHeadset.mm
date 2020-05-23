#import <AVFoundation/AVFoundation.h>

extern "C" {

	int _Detect() {
		
        AVAudioSessionRouteDescription* route = [[AVAudioSession sharedInstance] currentRoute];
        
        for (AVAudioSessionPortDescription* desc in [route outputs]) {
            if ([[desc portType] isEqualToString:AVAudioSessionPortHeadphones])
                return 1;
            if ([[desc portType] isEqualToString:AVAudioSessionPortBluetoothHFP])
                return 2;
	    //It was displaying this route for bluetooth wireless headphones.
            //Tested with Unity 2019.1
            if ([[desc portType] isEqualToString:AVAudioSessionPortBluetoothA2DP])
                return 2;
        }
        
        return 0;
        
	}
	
}