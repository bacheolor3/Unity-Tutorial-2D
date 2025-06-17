using UnityEngine;

public class WirelessEarPhone2 : WireEarPhone
{
    //public float batterySize;
    //public bool isWirelessCharged;
    public bool isNoiseCancelling;

    //public void Charged()
    //{
    //    string msg = isWirelessCharged ? "무선 충전" : "유선 충전";
    //    Debug.Log(msg);
    //}

    public virtual void NoiseCancelling()
    {
        isNoiseCancelling = !isNoiseCancelling;

        string msg = isNoiseCancelling ? "노이즈 캔슬링 On" : "노이즈 캔슬링 Off";
        Debug.Log(msg);
    }
}
