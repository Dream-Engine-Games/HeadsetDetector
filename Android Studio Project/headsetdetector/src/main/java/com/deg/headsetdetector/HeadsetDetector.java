package com.deg.headsetdetector;

import android.media.AudioManager;
import android.content.Context;
import android.util.Log;

public class HeadsetDetector {

    public static AudioManager audioManager;

    public HeadsetDetector(Context context){
        Log.i("DEG", "HeadsetDetector: Created ");
        audioManager = (AudioManager)context.getSystemService(Context.AUDIO_SERVICE);
    }

    public int Detect(){

        Log.i("DEG", "HeadsetDetector: Detect Function Called");
        //0 = NONE
        //1 = Wired
        //2 = Bluetooth
        if(audioManager.isWiredHeadsetOn())
            return 1;
        if(audioManager.isBluetoothScoOn() || audioManager.isBluetoothScoOn())
            return 2;
        return 0;
    }
}
