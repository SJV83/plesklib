namespace maestropanel.plesklib.Models
{
    using System.Xml.Serialization;

    [XmlRoot("packet")]
    public class FtpUserUpdatePacket
    {
        public FtpUserUpdatePacket()
        {
            this.ftpUser = new FtpUserUpdateUserNode();
        }

        [XmlElement("ftp-user")]
        public FtpUserUpdateUserNode ftpUser { get; set; }
    }

    public class FtpUserUpdateUserNode
    {
        public FtpUserUpdateUserNode()
        {
            this.set = new FtpUserUpdateSetNode();
        }

        [XmlElement("set")]
        public FtpUserUpdateSetNode set { get; set; }
    }

    public class FtpUserUpdateSetNode
    {
        public FtpUserUpdateSetNode()
        {
            this.filter = new FtpUserUpdateFiltersNode();
            this.values = new FtpUserUpdateValuesNode();
        }
        [XmlElement("filter")]
        public FtpUserUpdateFiltersNode filter { get; set; }
        [XmlElement("values")]
        public FtpUserUpdateValuesNode values { get; set; }
    }

    public class FtpUserUpdateFiltersNode
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("id")]
        public int Id { get; set; }
    }

    public class FtpUserUpdateValuesNode
    {
        [XmlElement("name")]
        public string username { get; set; }

        [XmlElement("password")]
        public string password { get; set; }

        [XmlElement("home")]
        public string home { get; set; }

        [XmlElement("create-non-existent")]
        public bool CreateDirectoryIfNotExists { get; set; }

        [XmlElement("quota")]
        public int quota { get; set; }

        [XmlElement("permissions")]
        public FtpUserGetPermissions permissions { get; set; }

        [XmlElement("webspace-name")]
        public string webspacename { get; set; }
    }
}
