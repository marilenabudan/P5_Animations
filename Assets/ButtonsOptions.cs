using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsOptions : MonoBehaviour
{
    public void SayHi()
    {
        if (!DitzelGames.FastIK.SampleProcedualAnimation.Instance.sayHi)
        {
            DitzelGames.FastIK.SampleProcedualAnimation.Instance.sayHi = true;
        }
        else if (DitzelGames.FastIK.SampleProcedualAnimation.Instance.sayHi)
        {
            DitzelGames.FastIK.SampleProcedualAnimation.Instance.sayHi = false;
        }
    }

    public void Jump()
    {
        if (!DitzelGames.FastIK.SampleProcedualAnimation.Instance.jump)
        {
            DitzelGames.FastIK.SampleProcedualAnimation.Instance.jump = true;
        }
        else if (DitzelGames.FastIK.SampleProcedualAnimation.Instance.jump)
        {
            DitzelGames.FastIK.SampleProcedualAnimation.Instance.jump = false;
        }
    }

    public void Stop()
    {
        DitzelGames.FastIK.SampleProcedualAnimation.Instance.sayHi = false;
        DitzelGames.FastIK.SampleProcedualAnimation.Instance.jump = false;
    }
}
