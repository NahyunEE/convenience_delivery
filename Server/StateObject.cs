using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace Server
{
    class StateObject
    {
        public Socket workSocket = null;

        public const int BufferSize = 4096;

        // Receive buffer
        public byte[] buffer = new byte[BufferSize];

    }
}
