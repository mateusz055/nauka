using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Class3
    {
        using (var resetEvent = new AutoResetEvent(false))
{
    var iBuffer = Convert.ToUInt32(resetEvent.SafeWaitHandle.DangerousGetHandle().ToInt32());
    // Pass iBuffer to unmanaged API function.  The unmanaged API passes in the wait handle as a ref uint.

    var handles = new[] { resetEvent, _cancellationTokenSource.Token.WaitHandle };
    while(WaitHandle.WaitAny(handles) == 0)
    {
       // do stuff in response to resetEvent being signaled.
    }
}
    }
}
