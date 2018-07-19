using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetOpenX.Rest.Client;
using NetOpenX.Rest.Client.Model;

namespace toplu
{
    [TestClass]
    public class UnitTest1
    {
        public static oAuth2 _oAuth2;

        [TestMethod]
        public void TestMethod1()
        {
            _oAuth2 = new oAuth2("http://localhost:7070");
            _oAuth2.Login(new JLogin()
            {
                BranchCode = 0,
                NetsisUser = "netsis",
                NetsisPassword = "1",
                DbType = JNVTTipi.vtMSSQL,
                DbName = "ENTERPRISE9",
                DbPassword = "sapass",
                DbUser = "TEMELSET"
            });
            string token = _oAuth2.AccessToken;

        }
    }
}
