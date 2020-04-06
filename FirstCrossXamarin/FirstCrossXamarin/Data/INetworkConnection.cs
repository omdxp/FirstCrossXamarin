using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCrossXamarin.Data
{
    public interface INetworkConnection
    {
        bool IsConnected { get; }
        void CheckNetworkConnection();
    }
}
