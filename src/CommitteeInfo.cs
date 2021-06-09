using Neo;
using Neo.SmartContract.Framework;

namespace CommitteeInfoContract
{
    public class CommitteeInfo
    {
        public UInt160 Hash;
        public string Name;
        public string Location;
        public string WebSite;
        public string Email;
        public string GitHub;
        public string Telegram;
        public string Twitter;
        public string Description;
    }

    public class KeyValue
    {
        public ByteString Key;
        public CommitteeInfo Value;
    }
}
