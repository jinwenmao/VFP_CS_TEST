using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using RemoteServer;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;

    namespace dll1
    {

        [ComVisible(true)]

        [Guid("A9762ABB-7FED-4CF0-B69B-4B5A594839C1")]

        [ProgId("dll1.Class1")]

        public class Class1 : Iclass1
        {

            public string getdll(string A)
            {

                string B = "1235";

                B = A + B;

                return B;

            }

            public void Initialize()

            { }





            public void Dispose()

            { }
            public void Test_remote()
            {
                //Type serverType = typeof(MyServer);
                Type serverType = typeof(MyServer);
             
                string url = GetActivationURL();

                RemotingConfiguration.RegisterWellKnownClientType(serverType, url);

                MyServer obj;
                obj = new MyServer();
                obj.Count();
                obj.Count();
            }

            string GetActivationURL()
            {
                return "tcp://10.10.10.20:8005/CounterServer";
                //if (m_TcpRadio.Checked)
                //{
                //    if (m_ServerRadio.Checked)
                //    {
                //        //Server activation over TCP. Note object URI
                //        // return "tcp://localhost:8005/CounterServer";
                //        return "tcp://10.10.10.20:8005/CounterServer";
                //    }
                //    else
                //    {
                //        //Client activation over tcp
                //        //return "tcp://localhost:8005";
                //        return "tcp://10.10.10.20:8005";
                //    }
                //}
                //if (m_HttpRadio.Checked)//http channel 
                //{
                //    if (m_ServerRadio.Checked)
                //    {
                //        //Server activation over http. Note object URI
                //        ///// //return "http://localhost:8006/CounterServer";
                //        return "http://10.10.10.20:8006/CounterServer";
                //    }
                //    else
                //    {
                //        //Client activation over http
                //        ////// return "http://localhost:8006";
                //        return "http://10.10.10.20:8006";
                //    }
                //}
                //else//IPC channel 
                //{
                //    if (m_ServerRadio.Checked)
                //    {
                //        //Server activation. Note object URI
                //        return "ipc://MyHost/CounterServer";
                //    }
                //    else
                //    {
                //        //Client activation
                //        return "ipc://MyHost";
                //    }
                //}

            }

        }

        [ComVisible(true)]

        [Guid("9B2FD85C-1610-4F05-B6FD-D86F501017D2")]

        public interface Iclass1
        {

            void Initialize();

            void Dispose();

            string getdll(string A);
            void Test_remote();



        }

    }

