namespace maestropanel.plesklib.Models
{
    using System.Xml.Serialization;

    [XmlRoot("packet")]
    public class FtpUserGetPacket
    {

        public FtpUserGetPacket()
        {
            this.ftpUser = new FtpUserGetFtpUser();
        }

        [XmlElement("ftp-user")]
        public FtpUserGetFtpUser ftpUser { get; set; }
    }

    public class FtpUserGetFtpUser
    {
        public FtpUserGetFtpUser()
        {
            this.get = new FtpUserGetNode();
        }

        [XmlElement("get")]
        public FtpUserGetNode get { get; set; }
    }

    public class FtpUserGetNode
    {
        public FtpUserGetNode()
        {
            filter = new FtpUserGetFilterNode();
        }

        [XmlElement("filter")]
        public FtpUserGetFilterNode filter { get; set; }
    }

    public class FtpUserGetFilterNode
    {
        [XmlElement("id")]
        public int Id { get; set; }
    }
}
