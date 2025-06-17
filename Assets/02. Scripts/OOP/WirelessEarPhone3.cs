using UnityEngine;

public class WirelessEarPhone3 : WirelessEarPhone2
{
    public enum NoiseCancelType {Off, On, Around}
    public NoiseCancelType noiseCancelType;

    public void setNoiseCancelType(NoiseCancelType type)
    {
        noiseCancelType = type;
    }

    public override void NoiseCancelling()
    {
        setNoiseCancelType(noiseCancelType);

        base.NoiseCancelling();
    }
}
