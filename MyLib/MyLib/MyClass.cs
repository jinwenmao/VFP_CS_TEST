using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;


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



        }

        [ComVisible(true)]

        [Guid("9B2FD85C-1610-4F05-B6FD-D86F501017D2")]

        public interface Iclass1
        {

            void Initialize();

            void Dispose();

            string getdll(string A);



        }

    }

