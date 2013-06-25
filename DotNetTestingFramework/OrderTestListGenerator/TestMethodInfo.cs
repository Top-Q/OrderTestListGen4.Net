using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OrderTestListGenerator
{
    [DataContract]
    public class TestMethodInfo
    {
        [DataMember]
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        private string storage;

        public string Storage
        {
            get { return storage; }
            set { storage = value; }
        }

        [DataMember]
        private string[] types;

        public string[] Types
        {
            get { return types; }
            set { types = value; }
        }

        [DataMember]
        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        [DataMember]
        private string culture;

        public string Culture
        {
            get { return culture; }
            set { culture = value; }
        }

        [DataMember]
        private string publicToken;

        public string PublicToken
        {
            get { return publicToken; }
            set { publicToken = value; }
        }

        public TestMethodInfo()
        {
            types = new string[2];
            types[0] = "Microsoft.VisualStudio.TestTools.TestTypes.Unit.UnitTestElement";
            types[1] = "Microsoft.VisualStudio.QualityTools.Tips.UnitTest.ObjectModel";
            culture = "neutral";
        }
    }
}
