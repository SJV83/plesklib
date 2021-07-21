using System.Xml.Serialization;

namespace maestropanel.plesklib.Models
{

    [XmlRoot("packet")]
    public class FtpUserGetResult : IResponseResult
    {
        private ApiResponse _response;

        public FtpUserGetResult()
        {
            this._response = new ApiResponse();
            this.ftpUser = new FtpUserGetResultFtpUserNode();
        }

        [XmlElement("ftp-user")]
        public FtpUserGetResultFtpUserNode ftpUser { get; set; }

        public void SaveResult(ApiResponse response)
        {
            _response = response;
        }

        public ResponseResult ToResult()
        {
            var result = new ResponseResult();
            return result;
        }
    }

    public class FtpUserGetResultFtpUserNode
    {
        [XmlElement("get")]
        public FtpUserGetResultGetNode get { get; set; }
    }

    public class FtpUserGetResultGetNode
    {
        public FtpUserGetResultGetNode()
        {
            Result = new FtpUserGetResultNode();
        }

        [XmlElement("result")]
        public FtpUserGetResultNode Result { get; set; }
    }

    public class FtpUserGetResultNode
    {
        public FtpUserGetResultNode()
        {
            permissions = new FtpUserGetPermissions();
        }

        [XmlElement("status")]
        public string status { get; set; }

        [XmlElement("filter-id")]
        public int filterId { get; set; }

        [XmlElement("id")]
        public int id { get; set; }

        [XmlElement("name")]
        public string name { get; set; }

        [XmlElement("home")]
        public string home { get; set; }

        [XmlElement("quota")]
        public string quota { get; set; }

        [XmlElement("permissions")]
        public FtpUserGetPermissions permissions { get; set; }

        [XmlElement("webspace-id")]
        public int webspaceId { get; set; }
    }

    public class FtpUserGetPermissions
    {
        /// <summary>
        /// Summary
        /// </summary>
        [XmlElement("read")]
        public bool read { get; set; }

        [XmlElement("write")]
        public bool write { get; set; }
    }
}

//namespace plesktest.model 
//{

//    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
//    public partial class packet
//    {

//        private packetFtpuser ftpuserField;

//        private string versionField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ftp-user")]
//        public packetFtpuser ftpuser
//        {
//            get
//            {
//                return this.ftpuserField;
//            }
//            set
//            {
//                this.ftpuserField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string version
//        {
//            get
//            {
//                return this.versionField;
//            }
//            set
//            {
//                this.versionField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//    public partial class packetFtpuser
//    {

//        private packetFtpuserResult[] getField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItemAttribute("result", IsNullable = false)]
//        public packetFtpuserResult[] get
//        {
//            get
//            {
//                return this.getField;
//            }
//            set
//            {
//                this.getField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//    public partial class packetFtpuserResult
//    {

//        private string statusField;

//        private byte filteridField;

//        private byte idField;

//        private string nameField;

//        private string homeField;

//        private byte webspaceidField;

//        /// <remarks/>
//        public string status
//        {
//            get
//            {
//                return this.statusField;
//            }
//            set
//            {
//                this.statusField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("filter-id")]
//        public byte filterid
//        {
//            get
//            {
//                return this.filteridField;
//            }
//            set
//            {
//                this.filteridField = value;
//            }
//        }

//        /// <remarks/>
//        public byte id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }

//        /// <remarks/>
//        public string name
//        {
//            get
//            {
//                return this.nameField;
//            }
//            set
//            {
//                this.nameField = value;
//            }
//        }

//        /// <remarks/>
//        public string home
//        {
//            get
//            {
//                return this.homeField;
//            }
//            set
//            {
//                this.homeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("webspace-id")]
//        public byte webspaceid
//        {
//            get
//            {
//                return this.webspaceidField;
//            }
//            set
//            {
//                this.webspaceidField = value;
//            }
//        }
//    }


//}
