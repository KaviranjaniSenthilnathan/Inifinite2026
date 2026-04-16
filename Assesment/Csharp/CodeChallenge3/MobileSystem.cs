using System;
public class MobilePhone
{
    public delegate void RingEventHandler();
    public event RingEventHandler OnRing;

    public void ReceiveCall()
    {
        Console.WriteLine("Incoming call...");
        OnRing?.Invoke();
    }
}
public class RingtonePlayer
{
    public void PlayRingtone()
    {
        Console.WriteLine("Playing ringtone...");
    }
}
public class ScreenDisplay
{
    public void ShowDisplay()
    {
        Console.WriteLine("Displaying caller info...");
    }
}
public class VibrationMotor
{
    public void Vibrate()
    {
        Console.WriteLine("Phone is vibrating...");
    }
}