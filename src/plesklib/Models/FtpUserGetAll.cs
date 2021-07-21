namespace maestropanel.plesklib.Models
{
    using System.Xml.Serialization;

    [XmlRoot("packet")]
    public class FtpUserGetAll
    {

        public FtpUserGetAll()
        {
            this.ftpUser = new FtpUserGetAllFtpUser();
        }

        [XmlElement("ftp-user")]
        public FtpUserGetAllFtpUser ftpUser { get; set; }
    }

    public class FtpUserGetAllFtpUser
    {
        public FtpUserGetAllFtpUser()
        {
            AllFtpUsers = new FtpUserGetAllGetNode();
        }

        [XmlElement("get")]
        public FtpUserGetAllGetNode AllFtpUsers { get; set; }
    }

    public class FtpUserGetAllGetNode
    {
        public FtpUserGetAllGetNode()
        {
            Filter = new GetFtpUserGetAllFilterNode();
        }

        [XmlElement("filter")]
        public GetFtpUserGetAllFilterNode Filter { get; set; }
    }

    public class GetFtpUserGetAllFilterNode
    {
        [XmlElement("webspace-id")]
        public int WebspaceId { get; set; }
    }
}
