using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.DTOs;
using VescNET.Domain.Interfaces;

namespace Test.Mocks
{
    public class BldcCommMock : IBldcComm
    {
        public IBuffer buffer;

        public bool Connected => true;

        public event EventHandler<ReceivedData> OnData;

        public void Send(IBuffer buffer)
        {
            this.buffer = buffer;
        }
    }
}
