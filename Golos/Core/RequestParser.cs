using System;

namespace Core
{
    public class RequestParser
    {
        public RequestParser()
        {
            //get microphone control

            //STT

            Tokenize("").Respond();
        }

        private Request Tokenize(string request)
        {
            Activator.CreateInstance(AppDomain.);


            return new Request(new Hello(), new string[] { });
        }
    }
}